using System.Windows.Forms;

namespace Lab_5.Presentation.Presenter {
    class MainPresenter : BasePresenter<View.IMainView> {

        private readonly Data.DataManager _data;
        private readonly Data.Repository.EmployeeJobFactory _dataFactory;

        public MainPresenter(View.IMainView view) : base(view) {
            _data = new Data.DataManager();
            _dataFactory = new Data.Repository.EmployeeJobFactory(_data);
            _view.OnReportClick += OnShowReport;
        }
        
        public override void Run() {
            _dataFactory?.Load();
            _view?.ShowEmployee(_data);
            base.Run();
        }

        private void OnShowReport(object sender, System.EventArgs e) {
            _dataFactory?.Save();
            _dataFactory?.Close();
            View.IReportView mainView = new Forms.ReportForm(new ApplicationContext());
            IPresenter mainPresenter = new ReportPresenter(mainView);
            mainPresenter?.Run();
        }

    }
}
