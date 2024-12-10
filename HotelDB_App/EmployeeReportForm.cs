using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace HotelDB_App
{
    public partial class EmployeeReportForm : Form
    {
        private readonly string connectionString = "Server=.;Database=HotelDB;Trusted_Connection=True;";

        public EmployeeReportForm()
        {
            InitializeComponent();
        }

        private void EmployeeReportForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT FullName, Age, Gender, Phone, PositionID FROM Employees";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewReport.DataSource = dataTable;
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
                    FileName = "EmployeeReport.csv"
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
    }
}
