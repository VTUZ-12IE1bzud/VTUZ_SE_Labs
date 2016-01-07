using Lab_7.Presentation.View;

namespace Lab_7.Presentation.Presenter {
    class DefectChartPresenter : BasePresenter<IChartView> {

        private const string REPORT_SALARY_MEMBER = "ViewEmloyeeSalary";
        private const string REPORT_DEFECT_MEMBER = "ViewEmployeeDefect";

        private readonly Data.DataManager _dm;
        private readonly Data.Repository.IViewRepository _repository; 

        public DefectChartPresenter(IChartView view, Data.Repository.IViewRepository repository) : base(view) {
            _dm = new Data.DataManager();
            _repository = repository;
            _repository?.SetDM(_dm);
        }

        public override void Run() {
            _repository?.Load();
            if (_repository is Data.Repository.EmployeeDefectRepository) {
                _view?.ShowChart(_dm, REPORT_DEFECT_MEMBER, "surname", "defect", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar);
            } else if (_repository is Data.Repository.EmployeeSalaryRepository) {
                _view?.ShowChart(_dm, REPORT_SALARY_MEMBER, "surname", "summa", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column);
            }
            _repository?.Close();
            base.Run();
        }
    }
}
