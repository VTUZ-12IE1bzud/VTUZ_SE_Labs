using Lab_3.Data.Adapter;

namespace Lab_3.Data.Repository {
    class JobRepository {

        private readonly DataManager _dm;

        public JobRepository(DataManager dm) {
            _dm = dm;
        }

        public void Load() {
            Adapter.DataManagerTableAdapters.JobTableAdapter tableAdapter 
                = new Adapter.DataManagerTableAdapters.JobTableAdapter();
            tableAdapter?.Fill(_dm?.Job);
        }

        public void Save() {
            Adapter.DataManagerTableAdapters.JobTableAdapter tableAdapter
                = new Adapter.DataManagerTableAdapters.JobTableAdapter();
            tableAdapter?.Update(_dm?.Job);
        }

        public void Close() {
            Adapter.DataManagerTableAdapters.JobTableAdapter tableAdapter
                = new Adapter.DataManagerTableAdapters.JobTableAdapter();
            tableAdapter?.Connection?.Close();
            
        }
    }

}
