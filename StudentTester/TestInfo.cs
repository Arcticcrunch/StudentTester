using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentTesterApp;

namespace StudentTester
{
    /// <summary>
    /// Данный класс содержит информацию об одном вопросе теста.
    /// </summary>
    public class TestInfo
    {
        private string testTitle;
        private string testTask;
        private TestType testType;
        private int correctVariant = 1;
        private string[] tasks;
        private string[] pictures;
        private int[] connections;

        public string TestTitle
        {
            get
            {
                return testTitle;
            }

            set
            {
                testTitle = value;
            }
        }
        public string TestTask
        {
            get
            {
                return testTask;
            }

            set
            {
                testTask = value;
            }
        }
        public TestType TestType
        {
            get
            {
                return testType;
            }

            set
            {
                testType = value;
            }
        }
        public int CorrectVariant
        {
            get
            {
                return correctVariant;
            }

            set
            {
                correctVariant = value;
            }
        }
        public string[] Tasks
        {
            get
            {
                return tasks;
            }

            set
            {
                tasks = value;
            }
        }
        public string[] Pictures
        {
            get
            {
                return pictures;
            }

            set
            {
                pictures = value;
            }
        }
        public int[] Connections
        {
            get
            {
                return connections;
            }

            set
            {
                connections = value;
            }
        }

        public TestInfo()
        {

        }

        public TestInfo(string testTitle, string testTask, TestType testType, int correctVariant, string[] tasks, string[] pictures, int[] connections)
        {
            this.testTitle = testTitle;
            this.testTask = testTask;
            this.testType = testType;
            this.correctVariant = correctVariant;
            this.tasks = tasks;
            this.pictures = pictures;
            this.connections = connections;
        }
    }
}
