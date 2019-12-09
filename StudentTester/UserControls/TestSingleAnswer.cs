using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTester
{
    public class TestSingleAnswer : BaseTest
    {
        private FlowLayoutPanel layoutPanel;
        private RadioButton[] radioButtons;

        public FlowLayoutPanel LayoutPanel
        {
            get
            {
                return layoutPanel;
            }
        }
        public RadioButton[] RadioButtons
        {
            get
            {
                return radioButtons;
            }

            set
            {
                radioButtons = value;
            }
        }

        public TestSingleAnswer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(492, 320);
            this.layoutPanel.TabIndex = 0;
            // 
            // TestSingleAnswer
            // 
            this.Controls.Add(this.layoutPanel);
            this.Name = "TestSingleAnswer";
            this.Size = new System.Drawing.Size(579, 399);
            this.ResumeLayout(false);

        }

        public override bool AcceptAnswer()
        {
            bool checkedAny = false;
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                {
                    checkedAny = true;
                    answer = Convert.ToString(i + 1);
                }
            }

            if (checkedAny)
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
