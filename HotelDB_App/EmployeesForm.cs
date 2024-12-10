using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class EmployeesForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-65RVNOI;Database=HotelDB;Trusted_Connection=True;";
        private BindingSource bindingSource = new BindingSource();

        public EmployeesForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        // Метод загрузки данных из таблицы Employees
        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT e.EmployeeID, e.FullName, e.Age, e.Gender, e.Address, e.Phone, e.Passport, p.PositionName 
                        FROM Employees e
                        LEFT JOIN Positions p ON e.PositionID = p.PositionID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    bindingSource.DataSource = dataTable;
                    dataGridViewEmployees.DataSource = bindingSource;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {sqlEx.Message}", "Ошибка SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки добавления сотрудника
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
                addEmployeeForm.ShowDialog();
                LoadEmployees(); // Перезагрузка списка сотрудников после добавления
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки удаления сотрудника
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["EmployeeID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmployeeID", employeeId);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Сотрудник удален.");
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик кнопки фильтрации по имени или паспорту
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtFilter.Text.Trim();
                if (!string.IsNullOrEmpty(filterText) && filterText != "Введите фильтр по имени/паспорту")
                {
                    bindingSource.Filter = $"FullName LIKE '%{filterText}%' OR Passport LIKE '%{filterText}%'";
                }
                else
                {
                    bindingSource.RemoveFilter(); // Сброс фильтра
                }
            }
            catch (EvaluateException evalEx)
            {
                MessageBox.Show($"Ошибка фильтрации: {evalEx.Message}", "Ошибка фильтра", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Фильтрация сотрудников по должности
        private void btnFilterByPosition_Click(object sender, EventArgs e)
        {
            try
            {
                string positionFilter = txtPositionFilter.Text.Trim();
                if (!string.IsNullOrEmpty(positionFilter) && positionFilter != "Введите фильтр по должности")
                {
                    bindingSource.Filter = $"PositionName LIKE '%{positionFilter}%'";
                }
                else
                {
                    bindingSource.RemoveFilter(); // Сброс фильтрации
                }
            }
            catch (EvaluateException evalEx)
            {
                MessageBox.Show($"Ошибка фильтрации по должности: {evalEx.Message}", "Ошибка фильтрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Переходы по записям
        private void btnFirst_Click(object sender, EventArgs e) => bindingSource.MoveFirst();
        private void btnPrevious_Click(object sender, EventArgs e) => bindingSource.MovePrevious();
        private void btnNext_Click(object sender, EventArgs e) => bindingSource.MoveNext();
        private void btnLast_Click(object sender, EventArgs e) => bindingSource.MoveLast();

        // Обработчики текстовых полей фильтров
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Введите фильтр по имени/паспорту")
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = Color.Black;
            }
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Введите фильтр по имени/паспорту";
                txtFilter.ForeColor = Color.Gray;
            }
        }

        private void txtPositionFilter_Enter(object sender, EventArgs e)
        {
            if (txtPositionFilter.Text == "Введите фильтр по должности")
            {
                txtPositionFilter.Text = "";
                txtPositionFilter.ForeColor = Color.Black;
            }
        }

        private void txtPositionFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPositionFilter.Text))
            {
                txtPositionFilter.Text = "Введите фильтр по должности";
                txtPositionFilter.ForeColor = Color.Gray;
            }
        }
    }
}
