using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentTester;

namespace StudentTesterApp
{
    public partial class MainForm : Form
    {
        private TestInfo[] testsInfo;
        private BaseTest[] testsArr;
        private int selectedTask = 0;
        private bool randomizeTasks = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StudentTesterMain.LoginForm.ShowDialog();
            //StartTest();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentTesterMain.InfoForm.Show();
        }

        public void StartTest()
        {
            testsInfo = TestsLoader.LoadTestsFromFile(@"Resources/Tasks.test");
            if (randomizeTasks)
            {
                testsInfo = RandomizeArray(testsInfo);
            }
            if (testsArr != null)
            {
                for (int i = 0; i < testsArr.Length; i++)
                {
                    testsArr[i].Dispose();
                }
            }
            TestSelector.Items.Clear();
            testsArr = new BaseTest[testsInfo.Length];
            Padding singleAnswerPadding = new Padding(35, 0, 0, 0);
            Padding multyAnswerPadding = new Padding(80, 0, 0, 0);
            int imageBottomPadding = 55;

            for (int i = 0; i < testsArr.Length; i++)
            {
                TestInfo info = testsInfo[i];
                switch (info.TestType)
                {
                    case TestType.Text:
                        TestText testText = new TestText();
                        testText.Parent = TestPanelHolder;
                        testText.Size = TestPanelHolder.Size;

                        TextBox textBox = new TextBox();
                        testText.AnswerBox = textBox;
                        textBox.Parent = testText;
                        textBox.Font = new Font(textBox.Font.FontFamily, 32);
                        textBox.BackColor = Color.FromArgb(255, 4, 13, 21);
                        textBox.ForeColor = Color.FromKnownColor(KnownColor.Control);
                        textBox.TextAlign = HorizontalAlignment.Center;
                        textBox.Width = 650;
                        textBox.Anchor = AnchorStyles.Left;
                        textBox.Left = (testText.Width - textBox.Width) / 2;
                        textBox.Top = (testText.Height - textBox.Height) / 2;
                        textBox.CharacterCasing = CharacterCasing.Upper;


                        testsArr[i] = testText;
                        break;
                    case TestType.SingleAnswer:
                        TestSingleAnswer testSingleAnswer = new TestSingleAnswer();
                        testSingleAnswer.Parent = TestPanelHolder;
                        testSingleAnswer.Size = TestPanelHolder.Size;
                        testSingleAnswer.LayoutPanel.Size = testSingleAnswer.Size;
                        testSingleAnswer.RadioButtons = new RadioButton[info.Tasks.Length];

                        for (int x = 0; x < info.Tasks.Length; x++)
                        {
                            RadioButton button = new RadioButton();
                            testSingleAnswer.RadioButtons[x] = button;
                            button.Parent = testSingleAnswer.LayoutPanel;
                            button.ForeColor = Color.FromKnownColor(KnownColor.Control);
                            button.Text = (x + 1) + ") " + info.Tasks[x];
                            button.Padding = singleAnswerPadding;
                            button.Font = new Font(button.Font.FontFamily, 20);

                            Size size = testSingleAnswer.LayoutPanel.Size;
                            size.Width = size.Width / 2 - 9;
                            size.Height = (size.Height / (int)Math.Ceiling(info.Tasks.Length * 0.5)) - 3;
                            button.Size = size;
                        }
                        testsArr[i] = testSingleAnswer;
                        break;
                    case TestType.MultyAnswer:
                        TestMultyAnswer testMultyAnswer = new TestMultyAnswer();

                        testMultyAnswer.Parent = TestPanelHolder;
                        testMultyAnswer.Size = TestPanelHolder.Size;
                        testMultyAnswer.LayoutPanel.Size = testMultyAnswer.Size;
                        testMultyAnswer.CheckBoxes = new CheckBox[info.Tasks.Length];
                        testMultyAnswer.MultyAnswer = new string[info.Tasks.Length];

                        for (int x = 0; x < info.Tasks.Length; x++)
                        {
                            CheckBox checkBox = new CheckBox();

                            testMultyAnswer.CheckBoxes[x] = checkBox;
                            checkBox.Parent = testMultyAnswer.LayoutPanel;
                            checkBox.ForeColor = Color.FromKnownColor(KnownColor.Control);
                            checkBox.Text = (x + 1) + ") " + info.Tasks[x];
                            checkBox.Padding = multyAnswerPadding;
                            checkBox.Font = new Font(checkBox.Font.FontFamily, 20);

                            Size size = testMultyAnswer.LayoutPanel.Size;
                            size.Height = (size.Height / info.Tasks.Length) - 3;
                            checkBox.Size = size;
                        }

                        testsArr[i] = testMultyAnswer;
                        break;
                    case TestType.Image:
                        TestImage testImage = new TestImage();
                        
                        testImage.Parent = TestPanelHolder;
                        testImage.Size = TestPanelHolder.Size;
                        testImage.LayoutPanel.Size = testImage.Size;
                        testImage.RadioButtons = new RadioButton[info.Tasks.Length];

                        for (int x = 0; x < info.Tasks.Length; x++)
                        {
                            RadioButton button = new RadioButton();
                            testImage.RadioButtons[x] = button;
                            button.Parent = testImage.LayoutPanel;
                            button.ForeColor = Color.FromKnownColor(KnownColor.Control);
                            button.Text = (x + 1) + ") " + info.Tasks[x];
                            button.Font = new Font(button.Font.FontFamily, 14);

                            Size size = testImage.LayoutPanel.Size;
                            size.Width = size.Width / 2 - 9;
                            size.Height = (size.Height / (int)Math.Ceiling(info.Tasks.Length * 0.5)) - 3;
                            button.Size = size;
                            Padding padding = new Padding(button.Width / 2, button.Height - imageBottomPadding, 0, 0);
                            button.Padding = padding;


                            PictureBox picture = new PictureBox();
                            string picturePath = @"Resources/";
                            picturePath += info.Pictures[x];
                            picture.Image = Image.FromFile(picturePath);
                            picture.Parent = button;
                            picture.SizeMode = PictureBoxSizeMode.Zoom;

                            int imageSideSize = button.Height - imageBottomPadding - 4;
                            picture.Size = new Size(imageSideSize, imageSideSize);
                            picture.Left = (button.Width / 2) - (imageSideSize / 2);
                            picture.Top = 4;
                        }

                        testsArr[i] = testImage;
                        break;
                    case TestType.Connection:
                        testsArr[i] = new TestConnection();
                        break;
                    default:
                        break;
                }
                testsArr[i].TestInfo = info;
                testsArr[i].Hide();

                TestSelector.Items.Add((i + 1) + ") " + info.TestTitle);
            }
            selectedTask = 0;
            Question.Text = "Вопрос: " + testsInfo[selectedTask].TestTask;
            testsArr[selectedTask].Show();
        }

        public TestInfo[] RandomizeArray(TestInfo[] list)
        {
            if (list != null)
            {
                if (list.Length > 0)
                {
                    List<TestInfo> resultList = new List<TestInfo>(list.Length);
                    List<int> avalablePositions = new List<int>(list.Length);
                    int[] resultIndeces = new int[list.Length];
                    Random rnd = new Random();
                    for (int i = 0; i < list.Length; i++)
                    {
                        avalablePositions.Add(i);
                    }

                    for (int i = 0; i < list.Length; i++)
                    {
                        int index = rnd.Next(0, avalablePositions.Count);
                        resultIndeces[i] = avalablePositions[index];
                        avalablePositions.RemoveAt(index);
                    }

                    for (int i = 0; i < list.Length; i++)
                    {
                        resultList.Add(list[resultIndeces[i]]);
                    }
                    return resultList.ToArray();
                }
                else return list;
            }
            else return null;
        }


        public void SelectTest(int index)
        {
            testsArr[selectedTask].Hide();
            selectedTask = index;
            testsArr[selectedTask].Show();
            Question.Text = "Вопрос: " + testsInfo[selectedTask].TestTask;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTesterMain.LoginForm.Show();
        }
        
        private void TestSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TestSelector.SelectedIndex;
            if (index > -1)
                SelectTest(TestSelector.SelectedIndex);
            TestSelector.Refresh();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (testsArr[selectedTask].AcceptAnswer())
            {
                SelectNextTest();
            }
            else PlayErrorSound();
            CheckIfTestDone();
        }

        // Отрисовка списка
        private void TestSelector_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Graphics != null && e.Index != -1)
            {
                TestSelector.DrawMode = DrawMode.OwnerDrawFixed;
                e.DrawBackground();    
                Brush brush = Brushes.Red;
                if (testsArr[e.Index].IsAnswerSelected)
                {
                    brush = Brushes.White;
                }
                e.Graphics.DrawString(TestSelector.Items[e.Index].ToString(),
                         e.Font, brush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void SelectNextTest()
        {
            int index = selectedTask + 1;
            if (index >= testsArr.Length)
                index = 0;
            SelectTest(index);
            TestSelector.SetSelected(index, true);
            TestSelector.Refresh();
        }
        private void SelectPreviousTest()
        {
            int index = selectedTask - 1;
            if (index < 0)
                index = testsArr.Length - 1;
            SelectTest(index);
            TestSelector.SetSelected(index, true);
            TestSelector.Refresh();
        }

        private void PreviousTestButton_Click(object sender, EventArgs e)
        {
            SelectPreviousTest();
        }
        private void NextTestButton_Click(object sender, EventArgs e)
        {
            SelectNextTest();
        }

        private void CheckIfTestDone()
        {
            bool testDone = true;
            for (int i = 0; i < testsArr.Length; i++)
            {
                if (testsArr[i].IsAnswerSelected == false)
                {
                    testDone = false;
                    break;
                }
            }

            if (testDone)
                TestDone();
        }

        private void TestDone()
        {
            this.Hide();
            StudentTesterMain.ResultForm.Show();
            StudentTesterMain.ResultForm.ResultText.Text = GetTestResult() + "/" + testsArr.Length;
        }
        
        private void PlayErrorSound()
        {
            System.Media.SystemSounds.Beep.Play();
        }

        public int GetTestResult()
        {
            int answers = 0;
            for (int i = 0; i < testsArr.Length; i++)
            {
                if(testsArr[i].IsAnswerSelected)
                {
                    switch (testsArr[i].TestInfo.TestType)
                    {
                        case TestType.Text:
                            if (testsArr[i].Answer == testsInfo[i].Tasks[0])
                                answers++;
                            break;
                        case TestType.SingleAnswer:
                            if (Convert.ToInt32(testsArr[i].Answer) == testsInfo[i].CorrectVariant)
                                answers++;
                            break;
                        case TestType.MultyAnswer:
                            bool correct = true;
                            for (int x = 0; x < testsArr[i].MultyAnswer.Length; x++)
                            {
                                if (testsArr[i].MultyAnswer[x] != testsInfo[i].Pictures[x])
                                {
                                    correct = false;
                                    break;
                                }
                            }
                            if (correct)
                                answers++;
                            break;
                        case TestType.Image:
                            if (Convert.ToInt32(testsArr[i].Answer) == testsInfo[i].CorrectVariant)
                                answers++;
                            break;
                        case TestType.Connection:
                            break;
                        default:
                            break;
                    }
                }
            }
            return answers;
        }

    }
}
