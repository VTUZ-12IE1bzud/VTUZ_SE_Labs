using Lab_7.Presentation.View;

namespace Lab_7.Presentation.Presenter {
    class SalaryReportPresenter : BasePresenter<IReportSalaryView> {

        private readonly Data.DataManager _dm;
        private readonly Data.Repository.EmployeeSalaryRepository _repository;

        public SalaryReportPresenter(IReportSalaryView view) : base(view) {
            _dm = new Data.DataManager();
            _repository = new Data.Repository.EmployeeSalaryRepository(_dm);
        }

        public override void Run() {
            _repository?.Load();
            _view?.ShowReport(_dm);
            _repository?.Close();
            base.Run();
        }
    }
}
