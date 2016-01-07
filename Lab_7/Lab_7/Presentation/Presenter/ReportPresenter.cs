using Lab_7.Presentation.View;

namespace Lab_7.Presentation.Presenter {
    class ReportPresenter : BasePresenter<IReportView> {

        private const string REPORT_SALARY_PATH = "Lab_7.Assets.ReportSalary.rdlc";
        private const string REPORT_DEFECT_PATH = "Lab_7.Assets.ReportDefect.rdlc";
        private const string REPORT_SALARY_MEMBER = "ViewEmloyeeSalary";
        private const string REPORT_DEFECT_MEMBER = "ViewEmployeeDefect";
        private const string REPORT_SALARY_PARAM = "DataReportSalary";
        private const string REPORT_DEFECT_PARAM = "DataReportDefect";

        private readonly Data.DataManager _dm;
        private readonly Data.Repository.IViewRepository _repository;

        public ReportPresenter(IReportView view, Data.Repository.IViewRepository repository) : base(view) {
            _dm = new Data.DataManager();
            _repository = repository;
            _repository?.SetDM(_dm);
        }

        public override void Run() {
            _repository?.Load();
            if (_repository is Data.Repository.EmployeeDefectRepository) {
                _view?.ShowReport(_dm, REPORT_DEFECT_MEMBER, REPORT_DEFECT_PATH, REPORT_DEFECT_PARAM);
            } else if (_repository is Data.Repository.EmployeeSalaryRepository) {
                _view?.ShowReport(_dm, REPORT_SALARY_MEMBER, REPORT_SALARY_PATH, REPORT_SALARY_PARAM);
            }
            _repository?.Close();
            base.Run();
        }
    }
}
