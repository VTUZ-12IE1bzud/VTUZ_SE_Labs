using Lab_3.Data.Adapter;

namespace Lab_3.Data.Repository {
    class EmployeeRepository {

        private readonly DataManager _dm;

        public EmployeeRepository(DataManager dm) {
            _dm = dm;
        }

        public void Load() {
            Adapter.DataManagerTableAdapters.EmployeeTableAdapter tableAdapter 
                = new Adapter.DataManagerTableAdapters.EmployeeTableAdapter();
            tableAdapter?.Fill(_dm?.Employee);
        }

        public void Save() {
            Adapter.DataManagerTableAdapters.EmployeeTableAdapter tableAdapter
                = new Adapter.DataManagerTableAdapters.EmployeeTableAdapter();
            tableAdapter?.Update(_dm?.Employee);
        }

        public void Close() {
            Adapter.DataManagerTableAdapters.EmployeeTableAdapter tableAdapter
                = new Adapter.DataManagerTableAdapters.EmployeeTableAdapter();
            tableAdapter?.Connection?.Close();
            
        }
    }

}
