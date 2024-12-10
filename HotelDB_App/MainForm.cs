using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class MainForm : Form
    {
        private string userRole;

        public MainForm(string role)
        {
            InitializeComponent();
            userRole = role;
            ApplyRoleRestrictions();
        }

        private void ApplyRoleRestrictions()
        {
            if (userRole == "reader")
            {
                btnClients.Enabled = false;
                btnEmployees.Enabled = false;
                btnReports.Enabled = false;
                btnClients.BackColor = Color.Gray;
                btnEmployees.BackColor = Color.Gray;
                btnReports.BackColor = Color.Gray;
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if (userRole == "admin")
            {
                ClientsForm clientsForm = new ClientsForm();
                clientsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому разделу.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (userRole == "admin")
            {
                EmployeesForm employeesForm = new EmployeesForm();
                employeesForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому разделу.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (userRole == "admin")
            {
                ReportsForm reportsForm = new ReportsForm();
                reportsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому разделу.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            bool isDarkTheme = chkDarkTheme.Checked;

            BackColor = isDarkTheme ? Color.FromArgb(45, 45, 48) : SystemColors.Control;
            ForeColor = isDarkTheme ? Color.White : SystemColors.ControlText;

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.BackColor = isDarkTheme ? Color.FromArgb(28, 28, 28) : SystemColors.ButtonFace;
                    control.ForeColor = isDarkTheme ? Color.White : SystemColors.ControlText;
                }
                else if (control is CheckBox)
                {
                    control.ForeColor = isDarkTheme ? Color.White : SystemColors.ControlText;
                }
            }
        }
    }
}
