using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class RoomsForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-65RVNOI;Database=HotelDB;Trusted_Connection=True;";
        private BindingSource bindingSource = new BindingSource();

        public RoomsForm()
        {
            InitializeComponent();
            LoadRooms();
        }

        // Метод загрузки данных из таблицы Rooms
        private void LoadRooms()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT RoomID, RoomName, Capacity, Description, Cost FROM Rooms";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    bindingSource.DataSource = dataTable;
                    dataGridViewRooms.DataSource = bindingSource;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {sqlEx.Message}", "Ошибка SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки номеров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки "Фильтр по вместимости"
        private void btnFilterByCapacity_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
                {
                    bindingSource.Sort = "[Capacity] ASC"; // Сортировка по вместимости от малого к большему
                }
                else
                {
                    MessageBox.Show("Нет данных для фильтрации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (EvaluateException evalEx)
            {
                MessageBox.Show($"Ошибка сортировки: {evalEx.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки "Сбросить фильтр"
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveFilter();
        }

        // Обработчики перемещения по записям
        private void btnFirst_Click(object sender, EventArgs e) => bindingSource.MoveFirst();
        private void btnPrevious_Click(object sender, EventArgs e) => bindingSource.MovePrevious();
        private void btnNext_Click(object sender, EventArgs e) => bindingSource.MoveNext();
        private void btnLast_Click(object sender, EventArgs e) => bindingSource.MoveLast();

        // Обработчик кнопки поиска
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText) && searchText != "Введите текст для поиска")
            {
                bindingSource.Filter = $"RoomName LIKE '%{searchText}%' OR Description LIKE '%{searchText}%'";
            }
            else
            {
                bindingSource.RemoveFilter();
            }
        }

        // Обработчик для входа в поле поиска
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Введите текст для поиска")
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.Black;
            }
        }

        // Обработчик для выхода из поля поиска
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Введите текст для поиска";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        // Обработчик кнопки закрытия формы
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обработчик кнопки "Добавить номер"
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm addRoomForm = new AddRoomForm();
            addRoomForm.ShowDialog();
            LoadRooms(); // Перезагрузить таблицу после добавления
        }
        // Обработчик кнопки "Удалить номер"
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        int roomId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["RoomID"].Value);
                        string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RoomID", roomId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Номер успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRooms(); // Перезагрузка данных после удаления
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления номера: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите номер для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
