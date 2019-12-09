using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTester
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void AppInfoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InfoForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void СreatorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/nikolol");
            this.Hide();
        }

        private void CreatorInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
