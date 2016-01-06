namespace Lab_6.Data.Repository {
    class JobRepository {

        private readonly DataManager _dm;

        public JobRepository(DataManager dm) {
            _dm = dm;
        }

        public void Load() {
            DataManagerTableAdapters.JobTableAdapter tableAdapter 
                = new DataManagerTableAdapters.JobTableAdapter();
            tableAdapter?.Fill(_dm?.Job);
        }

        public void Save() {
            DataManagerTableAdapters.JobTableAdapter tableAdapter
                = new DataManagerTableAdapters.JobTableAdapter();
            tableAdapter?.Update(_dm?.Job);
        }

        public void Close() {
            DataManagerTableAdapters.JobTableAdapter tableAdapter
                = new DataManagerTableAdapters.JobTableAdapter();
            tableAdapter?.Connection?.Close();
            
        }
    }

}
