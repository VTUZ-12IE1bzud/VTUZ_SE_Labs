using System;

namespace Lab_7.Data.Repository {
    class EmployeeSalaryRepository : IViewRepository {

        private DataManager _dm;

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

        public void SetDM(DataManager dm) {
            _dm = dm;
        }
    }

}
