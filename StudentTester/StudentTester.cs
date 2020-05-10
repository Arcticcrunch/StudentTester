using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentTester;

namespace StudentTesterApp
{
    static class StudentTesterMain
    {
        private static MainForm mainForm;
        private static LoginForm loginForm;
        private static InfoForm infoForm;
        private static ResultForm resultForm;

        public static MainForm MainForm
        {
            get
            {
                return mainForm;
            }
        }
        public static LoginForm LoginForm
        {
            get
            {
                return loginForm;
            }
        }
        public static Form InfoForm
        {
            get
            {
                return infoForm;
            }
        }
        public static ResultForm ResultForm
        {
            get
            {
                return resultForm;
            }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Создание всех используемых форм
            mainForm = new MainForm();
            loginForm = new LoginForm();
            infoForm = new InfoForm();
            resultForm = new ResultForm();
            // Запуск главной формы
            Application.Run(mainForm);
        }
    }
}
