using System;
using System.Data;

namespace HotelDB_App
{
    /// <summary>
    /// Представляет набор данных для отчетов о сотрудниках.
    /// </summary>
    public class EmployeeReportDataset : DataSet
    {
        public DataTable EmployeesTable { get; private set; }

        public EmployeeReportDataset()
        {
            InitDataset();
        }

        private void InitDataset()
        {
            // Создание таблицы Employees
            EmployeesTable = new DataTable("Employees");

            // Добавление колонок
            EmployeesTable.Columns.Add("FullName", typeof(string));    // ФИО
            EmployeesTable.Columns.Add("Age", typeof(int));           // Возраст
            EmployeesTable.Columns.Add("Gender", typeof(string));     // Пол
            EmployeesTable.Columns.Add("Phone", typeof(string));      // Телефон
            EmployeesTable.Columns.Add("PositionID", typeof(int));    // Код должности

            // Добавляем таблицу в DataSet
            Tables.Add(EmployeesTable);
        }

        /// <summary>
        /// Добавляет строку в таблицу сотрудников.
        /// </summary>
        public void AddEmployee(string fullName, int age, string gender, string phone, int positionID)
        {
            var row = EmployeesTable.NewRow();
            row["FullName"] = fullName;
            row["Age"] = age;
            row["Gender"] = gender;
            row["Phone"] = phone;
            row["PositionID"] = positionID;
            EmployeesTable.Rows.Add(row);
        }

        /// <summary>
        /// Очищает данные таблицы сотрудников.
        /// </summary>
        public void ClearEmployees()
        {
            EmployeesTable.Clear();
        }
    }
}
