using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class AddClientForm : Form
    {
        private readonly string connectionString = "Server=.;Database=HotelDB;Trusted_Connection=True;";

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO Clients (FullName, Passport, CheckInDate, CheckOutDate, RoomID, Cost) 
                        VALUES (@FullName, @Passport, @CheckInDate, @CheckOutDate, @RoomID, @Cost)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        command.Parameters.AddWithValue("@Passport", txtPassport.Text);
                        command.Parameters.AddWithValue("@CheckInDate", dtpCheckInDate.Value);
                        command.Parameters.AddWithValue("@CheckOutDate", dtpCheckOutDate.Value);
                        command.Parameters.AddWithValue("@RoomID", Convert.ToInt32(txtRoomID.Text));
                        command.Parameters.AddWithValue("@Cost", Convert.ToDecimal(txtCost.Text));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Клиент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
