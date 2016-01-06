namespace Lab_5.Data.Repository {
    class EmployeeSalaryRepository {

        private readonly DataManager _dm;

        public EmployeeSalaryRepository(DataManager dm) {
            _dm = dm;
        }

        public void Load() {
            DataManagerTableAdapters.ViewEmloyeeSalaryTableAdapter tableAdapter 
                = new DataManagerTableAdapters.ViewEmloyeeSalaryTableAdapter();
            tableAdapter?.Fill(_dm?.ViewEmloyeeSalary);
        }

        public void Close() {
            DataManagerTableAdapters.ViewEmloyeeSalaryTableAdapter tableAdapter
                = new DataManagerTableAdapters.ViewEmloyeeSalaryTableAdapter();
            tableAdapter?.Connection?.Close();
        }
    }

}
