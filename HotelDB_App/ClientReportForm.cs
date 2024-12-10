using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class ClientReportForm : Form
    {
        private readonly string connectionString = "Server=.;Database=HotelDB;Trusted_Connection=True;";
        private BindingSource bindingSource = new BindingSource();

        public ClientReportForm()
        {
            InitializeComponent();
        }

        private void ClientReportForm_Load(object sender, EventArgs e)
        {
            LoadClientData();
        }

        private void LoadClientData()
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
                    dataGridViewReport.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }

        private void ExportToCSV()
        {
            if (dataGridViewReport.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    FileName = "ClientReport.csv"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Заголовки
                            for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
                            {
                                sw.Write(dataGridViewReport.Columns[i].HeaderText);
                                if (i < dataGridViewReport.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();

                            // Данные
                            foreach (DataGridViewRow row in dataGridViewReport.Rows)
                            {
                                for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dataGridViewReport.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show("Отчет успешно экспортирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет данных для экспорта!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e) => bindingSource.MoveFirst();

        private void btnPrevious_Click(object sender, EventArgs e) => bindingSource.MovePrevious();

        private void btnNext_Click(object sender, EventArgs e) => bindingSource.MoveNext();

        private void btnLast_Click(object sender, EventArgs e) => bindingSource.MoveLast();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.SelectedRows.Count > 0)
            {
                int clientId = Convert.ToInt32(dataGridViewReport.SelectedRows[0].Cells["ClientID"].Value);

                try
                {
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
                    MessageBox.Show("Клиент удален.");
                    LoadClientData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            LoadClientData();
        }
    }
}
