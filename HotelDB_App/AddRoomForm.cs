using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class AddRoomForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-65RVNOI;Database=HotelDB;Trusted_Connection=True;";

        public AddRoomForm()
        {
            InitializeComponent();
        }

        // Обработчик кнопки "Сохранить"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверяем, заполнены ли все поля
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtCost.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Rooms (RoomName, Capacity, Description, Cost) VALUES (@RoomName, @Capacity, @Description, @Cost)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Передаем данные из текстовых полей в параметры SQL-запроса
                        command.Parameters.AddWithValue("@RoomName", txtRoomName.Text);
                        command.Parameters.AddWithValue("@Capacity", int.Parse(txtCapacity.Text)); // Проверка на целое число
                        command.Parameters.AddWithValue("@Description", txtDescription.Text);
                        command.Parameters.AddWithValue("@Cost", decimal.Parse(txtCost.Text)); // Проверка на число с плавающей запятой

                        connection.Open();
                        command.ExecuteNonQuery(); // Выполняем запрос

                        MessageBox.Show("Номер успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Очистка полей после успешного сохранения
                        txtRoomName.Clear();
                        txtCapacity.Clear();
                        txtDescription.Clear();
                        txtCost.Clear();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для вместимости и стоимости!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
