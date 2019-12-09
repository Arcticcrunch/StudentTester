using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentTesterApp;

namespace StudentTester
{
    public static class TestsLoader
    {
        public static TestInfo[] LoadTestsFromFile(string path)
        {
            List<TestInfo> testList = new List<TestInfo>();
            using (StreamReader fs = new StreamReader(path, Encoding.GetEncoding(1251)))
            {
                bool ignoreString = false;
                bool testFound = false;
                ReadingType type = ReadingType.None;

                string title = "default title";
                string task = "default task";
                int correctVariant = 1;
                TestType currentTestType = TestType.Text;
                List<string> fieldsList = new List<string>();
                List<string> picturesList = new List<string>();
                List<int> connectionsList = new List<int>();
                
                int buffer;
                string strBuffer = "";
                
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
            return testList.ToArray();
        }

        private static string GetInstructionArg(string instruction, string str)
        {
            int pos = str.IndexOf(instruction);
            string subStr = str.Remove(pos, instruction.Length);
            subStr = subStr.Trim('\n');
            subStr = subStr.Trim('\r');
            subStr = subStr.Trim('\t');
            return subStr;
        }

        private enum ReadingType
        {
            Instruction, Variant, None
        }
    }

    public enum TestType
    {
        Text, SingleAnswer, MultyAnswer, Image, Connection
    }
}
