using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTester
{
    public class BaseTest : UserControl
    {
        private TestInfo testInfo;
        protected bool isAnswerSelected = false;
        protected string answer = "";
        protected string[] multyAnswer;

        public BaseTest()
        {
            InitializeComponent();
        }
        
        public TestInfo TestInfo
        {
            get
            {
                return testInfo;
            }

            set
            {
                testInfo = value;
            }
        }
        public bool IsAnswerSelected
        {
            get
            {
                return isAnswerSelected;
            }
        }
        public string Answer
        {
            get
            {
                return answer;
            }
        }
        public string[] MultyAnswer
        {
            get
            {
                return multyAnswer;
            }
            set
            {
                multyAnswer = value;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TestsList
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Name = "TestsList";
            this.Size = new System.Drawing.Size(441, 336);
            this.ResumeLayout(false);

        }
        
        public virtual bool AcceptAnswer()
        {
            throw new NotImplementedException("Этот метод нужно переопределить в дочерних классах!");
        }
        
    }
}
