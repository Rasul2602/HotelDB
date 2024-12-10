using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class AddEmployeeForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-65RVNOI.;Database=HotelDB;Trusted_Connection=True;";

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Employees (FullName, Age, Gender, Address, Phone, Passport, PositionID) VALUES (@FullName, @Age, @Gender, @Address, @Phone, @Passport, @PositionID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    command.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    command.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@Passport", txtPassport.Text);
                    command.Parameters.AddWithValue("@PositionID", int.Parse(txtPositionID.Text));

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Очистить поля после добавления
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtPhone.Clear();
            txtPassport.Clear();
            txtPositionID.Clear();
        }
    }
}
