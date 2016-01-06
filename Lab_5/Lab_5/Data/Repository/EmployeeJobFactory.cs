namespace Lab_5.Data.Repository {
    class EmployeeJobFactory {

        private readonly EmployeeRepository _employee;
        private readonly JobRepository _job;

        public EmployeeJobFactory(DataManager dm) {
            _employee = new EmployeeRepository(dm);
            _job = new JobRepository(dm);
        }

        public void Load() {
            _employee?.Load();
            _job?.Load();
        }

        public void Save() {
            _employee?.Save();
            _job?.Save();
        }

        public void Close() {
            _employee?.Close();
            _job?.Close();
        }

    }
}
