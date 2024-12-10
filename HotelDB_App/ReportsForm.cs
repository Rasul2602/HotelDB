using System;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnClientReport_Click(object sender, EventArgs e)
        {
            ClientReportForm clientReportForm = new ClientReportForm();
            clientReportForm.ShowDialog();
        }

        private void btnEmployeeReport_Click(object sender, EventArgs e)
        {
            EmployeeReportForm employeeReportForm = new EmployeeReportForm();
            employeeReportForm.ShowDialog();
        }

        private void btnRoomReport_Click(object sender, EventArgs e)
        {
            RoomReportForm roomReportForm = new RoomReportForm();
            roomReportForm.ShowDialog();
        }
    }
}
