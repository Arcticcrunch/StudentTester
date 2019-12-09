using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTester
{
    public class TestText : BaseTest
    {
        private TextBox answerBox;

        public TextBox AnswerBox
        {
            get
            {
                return answerBox;
            }

            set
            {
                answerBox = value;
            }
        }


        public TestText()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TestText
            // 
            this.Name = "TestText";
            this.Size = new System.Drawing.Size(443, 368);
            this.ResumeLayout(false);

        }

        public override bool AcceptAnswer()
        {
            answer = answerBox.Text;
            if (answerBox.Text != "")
            {
                isAnswerSelected = true;
                return true;
            }
            else
            {
                isAnswerSelected = false;
                return false;
            }
        }
    }
}
