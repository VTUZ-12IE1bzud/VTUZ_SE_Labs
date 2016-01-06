using System.Data;
using System.Data.OleDb;

namespace Lab_4.Data.Repository {
    class EmployeeRepository {

        private const string REQUEST_GET_EMPLOYEE = "SELECT Employee.surname, Employee.name, Employee.patronymic, Salary.salary "
            + "FROM Employee INNER JOIN Salary ON Employee.id = Salary.id";

        private readonly OleDbConnection _connection;

        public EmployeeRepository() {
            _connection = new OleDbConnection(Properties.Settings.Default.DataConnectionString);
        }

        public DataSet GetEmployee(string adapterKey) {
            Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = _connection;
            command.CommandText = REQUEST_GET_EMPLOYEE;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, adapterKey);
            Close();
            return dataSet;
        }

        private void Open() {
            _connection?.Open();
        }

        private void Close() {
            _connection?.Close();
        }

    }
}
