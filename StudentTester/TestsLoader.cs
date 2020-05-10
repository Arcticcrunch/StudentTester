using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentTesterApp;

namespace StudentTester
{
    /// <summary>
    /// Загрузчик тестовых файлов в программу
    /// </summary>
    public static class TestsLoader
    {
        /// <summary>
        /// Загрузка всех заданий из файла
        /// </summary>
        /// <param name="path">Путь к файлу вместе с его именем и расширением</param>
        /// <returns></returns>
        public static TestInfo[] LoadTestsFromFile(string path)
        {
            // Создание списка объектов класса TestInfo. Объект класса TestInfo содержит информацию об одном вопросе теста
            List<TestInfo> testList = new List<TestInfo>();
            // Открытие файла. Использование ключевого слова using гарантирует освобождение неуправляемых ресурсов (закрытие файла)
            // в конце блока кода (в фигурных скобках) + включение кодировки для корректного чтения русских букв.
            using (StreamReader fs = new StreamReader(path, Encoding.GetEncoding(1251)))
            {
                // Флаг указывающий игнорировать ли текущую строку которую читает загрузчик (например если она помечена как комментарий)
                bool ignoreString = false;
                // Флаг указывающий найден ли в данный момент тест. Если тест не найден загрузчик будет игнорировать все встречающиеся символы
                // пока не найдёт заглавную букву T
                bool testFound = false;
                // Тип информации на текущей строке
                ReadingType type = ReadingType.None;

                // Название задания (отображаеться в списке тестов)
                string title = "default title";
                // Текст задания
                string task = "default task";
                // Правильный вариант ответа текущего обрабатываемого теста
                int correctVariant = 1;
                // Тип найденного теста
                TestType currentTestType = TestType.Text;
                // Список всех текстовых полей для текущего теста
                List<string> fieldsList = new List<string>();
                // Список всех изображений в тестах с изображениями для текущего вопроса (если есть)
                List<string> picturesList = new List<string>();
                // Список всех соответствия в тесте на соответствие для текущего вопроса (если есть)
                List<int> connectionsList = new List<int>();

                // Буфферный байт. В него записывается текущий читаемый символ.
                // Имеет тип int т.к. метод StreamReader.Read() возвращает тип int (хотя по идее должен byte)
                int buffer;
                // Буферная строка. В неё записываются символы из буффера buffer. После чтения и обработки экранной строки этот буфер очищается
                // и в него записывается следующая строка.
                string strBuffer = "";
                
                // Чтение файла до самого конца
                while(fs.EndOfStream == false)
                {
                    buffer = fs.Read();
                    if (ignoreString)
                    {
                        if (buffer == '\n')
                        {
                            ignoreString = false;
                        }
                    }
                    else
                    {
                        if (testFound)
                        {
                            switch (type)
                            {
                                case ReadingType.Instruction:
                                    strBuffer += Convert.ToChar(buffer);
                                    if (buffer == '\n')
                                    {
                                        if (strBuffer.Contains("Title:"))
                                        {
                                            title = GetInstructionArg("Title:", strBuffer);
                                        }
                                        else if (strBuffer.Contains("Task:"))
                                        {
                                            task = GetInstructionArg("Task:", strBuffer);
                                        }
                                        else if (strBuffer.Contains("Type:"))
                                        {
                                            string typeStr = GetInstructionArg("Type:", strBuffer);
                                            if (typeStr == "Text")
                                                currentTestType = TestType.Text;
                                            else if (typeStr == "SingleAnswer")
                                                currentTestType = TestType.SingleAnswer;
                                            else if (typeStr == "MultyAnswer")
                                                currentTestType = TestType.MultyAnswer;
                                            else if (typeStr == "Image")
                                                currentTestType = TestType.Image;
                                            else if (typeStr == "Connection")
                                                currentTestType = TestType.Connection;
                                        }
                                        else if (strBuffer.Contains("Correct:"))
                                        {
                                            correctVariant = Convert.ToInt32(GetInstructionArg("Correct:", strBuffer));
                                        }
                                        type = ReadingType.None;
                                        strBuffer = "";
                                    }
                                    break;
                                case ReadingType.Variant:
                                    strBuffer += Convert.ToChar(buffer);
                                    if (buffer == '\n')
                                    {
                                        if (strBuffer.Contains("@Field:"))
                                        {
                                            fieldsList.Add(GetInstructionArg("@Field:", strBuffer));
                                        }
                                        else if (strBuffer.Contains("@Picture:"))
                                        {
                                            picturesList.Add(GetInstructionArg("@Picture:", strBuffer));
                                        }
                                        else if (strBuffer.Contains("@Connection:"))
                                        {
                                            connectionsList.Add(Convert.ToInt32(GetInstructionArg("@Connection:", strBuffer)));
                                        }
                                        else if (strBuffer.Contains("@E"))
                                        {
                                            type = ReadingType.None;
                                        }
                                        strBuffer = "";
                                    }
                                    break;
                                case ReadingType.None:
                                    if (buffer == '@')
                                        type = ReadingType.Instruction;
                                    else if (buffer == 'V')
                                        type = ReadingType.Variant;
                                    else if (buffer == 'S')
                                    {
                                        testFound = false;

                                        TestInfo info = new TestInfo
                                        {
                                            TestTitle = title,
                                            TestTask = task,
                                            CorrectVariant = correctVariant,
                                            TestType = currentTestType,
                                            Tasks = fieldsList.ToArray(),
                                            Pictures = picturesList.ToArray(),
                                            Connections = connectionsList.ToArray()
                                        };

                                        testList.Add(info);

                                        fieldsList.Clear();
                                        picturesList.Clear();
                                        connectionsList.Clear();
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            if (buffer == '#')
                            {
                                ignoreString = true;
                            }
                            else if (buffer == 'T')
                            {
                                testFound = true;
                            }
                        }
                    }
                }
            }
            // Возвращение полученнного списка с преобразованием его в массив
            return testList.ToArray();
        }

        /// <summary>
        /// Достать из строки значение следующие сразу после подстроки instruction
        /// </summary>
        /// <param name="instruction">Подстрока значение после которой нужно получить</param>
        /// <param name="str">Вся строка (имеется ввиду экранная строка (до нажатия Enter), а не строка string)</param>
        /// <returns></returns>
        private static string GetInstructionArg(string instruction, string str)
        {
            int pos = str.IndexOf(instruction);
            string subStr = str.Remove(pos, instruction.Length);
            subStr = subStr.Trim('\n');
            subStr = subStr.Trim('\r');
            subStr = subStr.Trim('\t');
            return subStr;
        }

        /// <summary>
        /// Тип информации на текущей строке (нужен для внутреннего пользования данным классом)
        /// </summary>
        private enum ReadingType
        {
            Instruction, Variant, None
        }
    }

    /// <summary>
    /// Перечисление, содержащее типы тестовых заданий
    /// </summary>
    public enum TestType
    {
        Text, SingleAnswer, MultyAnswer, Image, Connection
    }
}
