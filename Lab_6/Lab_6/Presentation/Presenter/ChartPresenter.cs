using Lab_6.Presentation.View;

namespace Lab_6.Presentation.Presenter {
    class ChartPresenter : BasePresenter<IChartView> {

        private readonly Data.DataManager _dm;
        private readonly Data.Repository.EmployeeSalaryRepository _repository;

        public ChartPresenter(IChartView view) : base(view) {
            _dm = new Data.DataManager();
            _repository = new Data.Repository.EmployeeSalaryRepository(_dm);
        }

        public override void Run() {
            _repository?.Load();
            _view?.ShowChart(_dm);
            base.Run();
        }
    }
}
