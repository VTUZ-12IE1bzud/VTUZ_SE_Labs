namespace Lab_7.Data.Repository {
    class EmployeeDefectRepository {

        private readonly DataManager _dm;

        public EmployeeDefectRepository(DataManager dm) {
            _dm = dm;
        }

        public void Load() {
            DataManagerTableAdapters.ViewEmployeeDefectTableAdapter tableAdapter
                = new DataManagerTableAdapters.ViewEmployeeDefectTableAdapter();
            tableAdapter.Fill(_dm?.ViewEmployeeDefect);
        }

      

        public void Close() {
            DataManagerTableAdapters.ViewEmployeeDefectTableAdapter tableAdapter
                = new DataManagerTableAdapters.ViewEmployeeDefectTableAdapter();
            tableAdapter?.Connection?.Close();

        }

    }
}
