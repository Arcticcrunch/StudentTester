using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTesterApp
{
    public partial class LoginForm : Form
    {
        protected bool isLogging = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            isLogging = true;
            this.Hide();
            StudentTesterMain.MainForm.StartTest();
            StudentTesterMain.MainForm.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogging == false || StudentTesterMain.MainForm.Visible == false)
                StudentTesterMain.MainForm.Close();
        }
        
    }
}
