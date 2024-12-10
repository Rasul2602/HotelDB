using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class ClientsForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-65RVNOI;Database=HotelDB;Trusted_Connection=True;";
        private BindingSource bindingSource = new BindingSource();

        public ClientsForm()
        {
            InitializeComponent();
            LoadClients();
        }

        // Метод загрузки данных из таблицы Clients
        private void LoadClients()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ClientID, FullName, Passport AS PassportData, CheckInDate, CheckOutDate, RoomID, Cost FROM Clients";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    bindingSource.DataSource = dataTable;
                    dataGridViewClients.DataSource = bindingSource;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {sqlEx.Message}", "Ошибка SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных клиентов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки "Добавить клиента"
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            LoadClients(); // Перезагрузить данные после добавления
        }

        // Обработчик кнопки "Удалить клиента"
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                try
                {
                    int clientId = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["ClientID"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Clients WHERE ClientID = @ClientID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ClientID", clientId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Клиент успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClients(); // Перезагрузка данных после удаления
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик кнопки фильтрации по тексту
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtFilter.Text.Trim();
                if (!string.IsNullOrEmpty(filterText))
                {
                    bindingSource.Filter = $"FullName LIKE '%{filterText}%' OR PassportData LIKE '%{filterText}%'";
                }
                else
                {
                    bindingSource.RemoveFilter();
                }
            }
            catch (EvaluateException evalEx)
            {
                MessageBox.Show($"Ошибка фильтрации: {evalEx.Message}", "Ошибка фильтра", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для фильтрации по номеру комнаты
        private void btnFilterRoom_Click(object sender, EventArgs e)
        {
            try
            {
                string roomText = txtRoomFilter.Text.Trim();
                if (!string.IsNullOrEmpty(roomText) && int.TryParse(roomText, out int roomId))
                {
                    bindingSource.Filter = $"RoomID = {roomId}";
                }
                else if (string.IsNullOrEmpty(roomText))
                {
                    bindingSource.RemoveFilter();
                }
                else
                {
                    MessageBox.Show("Введите корректный номер комнаты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (EvaluateException evalEx)
            {
                MessageBox.Show($"Ошибка фильтрации по номеру комнаты: {evalEx.Message}", "Ошибка фильтра", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик входа в текстовое поле фильтрации
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Введите данные для фильтрации")
            {
                txtFilter.Text = ""; // Очистка текстового поля
                txtFilter.ForeColor = Color.Black;
            }
        }

        // Обработчик выхода из текстового поля фильтрации
        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Введите данные для фильтрации"; // Восстановление текста по умолчанию
                txtFilter.ForeColor = Color.Gray;
            }
        }

        // Обработчик входа в текстовое поле фильтрации по номеру
        private void txtRoomFilter_Enter(object sender, EventArgs e)
        {
            if (txtRoomFilter.Text == "Введите номер комнаты")
            {
                txtRoomFilter.Text = ""; // Очистка текстового поля
                txtRoomFilter.ForeColor = Color.Black;
            }
        }

        // Обработчик выхода из текстового поля фильтрации по номеру
        private void txtRoomFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomFilter.Text))
            {
                txtRoomFilter.Text = "Введите номер комнаты"; // Восстановление текста по умолчанию
                txtRoomFilter.ForeColor = Color.Gray;
            }
        }
    }
}
