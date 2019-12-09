using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTester
{
    public class TestMultyAnswer : BaseTest
    {
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private CheckBox[] checkBoxes;

        public FlowLayoutPanel LayoutPanel
        {
            get
            {
                return layoutPanel;
            }
        }
        public CheckBox[] CheckBoxes
        {
            get
            {
                return checkBoxes;
            }

            set
            {
                checkBoxes = value;
            }
        }

        public TestMultyAnswer()
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
            this.layoutPanel.Size = new System.Drawing.Size(353, 259);
            this.layoutPanel.TabIndex = 0;
            // 
            // TestMultyAnswer
            // 
            this.Controls.Add(this.layoutPanel);
            this.Name = "TestMultyAnswer";
            this.ResumeLayout(false);

        }

        public override bool AcceptAnswer()
        {
            bool checkedAny = false;
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    checkedAny = true;
                    multyAnswer[i] = Convert.ToString(1);
                }
                else multyAnswer[i] = Convert.ToString(0);
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
