using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentTesterApp;

namespace StudentTester
{
    public partial class ResultForm : Form
    {

        public ResultForm()
        {
            InitializeComponent();
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTesterMain.MainForm.Show();
            StudentTesterMain.MainForm.StartTest();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTesterMain.MainForm.Hide();
            StudentTesterMain.LoginForm.Show();
        }

        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
