using System;
using System.Windows.Forms;

namespace HotelDB_App
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Показ заставки
            SplashScreenForm splash = new SplashScreenForm();
            splash.ShowDialog();

            // Показ формы авторизации
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Открытие главного меню с учетом роли пользователя
                    Application.Run(new MainForm(loginForm.UserRole));
                }
            }
        }
    }
}
