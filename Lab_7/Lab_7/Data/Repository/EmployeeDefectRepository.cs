using System;

namespace Lab_7.Data.Repository {
    class EmployeeDefectRepository : IViewRepository {

        private DataManager _dm;

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

        public void SetDM(DataManager dm) {
            _dm = dm;
        }
    }
}
