using System;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class LoginForm : Form
    {
        public string UserRole { get; private set; } = string.Empty; // Роль пользователя

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "admin")
            {
                UserRole = "admin";
            }
            else if (username == "reader" && password == "reader")
            {
                UserRole = "reader";
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Успешная авторизация
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Завершение приложения
        }
    }
}
