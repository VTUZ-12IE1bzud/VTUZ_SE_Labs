using Lab_7.Presentation.View;

namespace Lab_7.Presentation.Presenter {
    class DefectChartPresenter : BasePresenter<IChartDefectView> {

        private readonly Data.DataManager _dm;
        private readonly Data.Repository.EmployeeDefectRepository _repository; 

        public DefectChartPresenter(IChartDefectView view) : base(view) {
            _dm = new Data.DataManager();
            _repository = new Data.Repository.EmployeeDefectRepository(_dm);
        }

        public override void Run() {
            _repository?.Load();
            _view?.ShowChart(_dm);
            _repository?.Close();
            base.Run();
        }
    }
}
