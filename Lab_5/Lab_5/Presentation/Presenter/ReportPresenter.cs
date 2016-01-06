using Lab_5.Presentation.View;

namespace Lab_5.Presentation.Presenter {
    class ReportPresenter : BasePresenter<IReportView> {

        private readonly Data.DataManager _dm;
        private readonly Data.Repository.EmployeeSalaryRepository _repository;

        public ReportPresenter(IReportView view) : base(view) {
            _dm = new Data.DataManager();
            _repository = new Data.Repository.EmployeeSalaryRepository(_dm);
        }

        public override void Run() {
            _repository?.Load();
            _view?.ShowReport(_dm);
            base.Run();
        }
    }
}
