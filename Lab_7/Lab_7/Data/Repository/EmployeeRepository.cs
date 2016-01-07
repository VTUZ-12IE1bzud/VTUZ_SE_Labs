namespace Lab_7.Data.Repository {
    class EmployeeRepository {

        private readonly DataManager _dm;

        public EmployeeRepository(DataManager dm) {
            _dm = dm;
        }

        public void Load() {
            DataManagerTableAdapters.EmployeeTableAdapter tableAdapter 
                = new DataManagerTableAdapters.EmployeeTableAdapter();
            tableAdapter?.Fill(_dm?.Employee);
        }

        public void Save() {
            DataManagerTableAdapters.EmployeeTableAdapter tableAdapter
                = new DataManagerTableAdapters.EmployeeTableAdapter();
            tableAdapter?.Update(_dm?.Employee);
        }

        public void Close() {
            DataManagerTableAdapters.EmployeeTableAdapter tableAdapter
                = new DataManagerTableAdapters.EmployeeTableAdapter();
            tableAdapter?.Connection?.Close();
            
        }
    }

}
