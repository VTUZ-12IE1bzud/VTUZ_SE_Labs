using System.Windows.Forms;
using Lab_7.Presentation.View;

namespace Lab_7.Presentation.Presenter {
    class MainPresenter : BasePresenter<View.IMainView> {

        private const string SORT_ASC = "surname ASC, name";
        private const string SORT_DESC = "surname DESC, name";

        private readonly Data.DataManager _dm;
        private readonly Data.Repository.EmployeeJobFactory _repository;

        public MainPresenter(IMainView view) : base(view) {
            _dm = new Data.DataManager();
            _repository = new Data.Repository.EmployeeJobFactory(_dm);
            _view.OnExitClick += OnExit;
            _view.OnFilterChange += OnFilterChange;
            _view.OnSaveClick += OnSave;
            _view.OnShowAboutClick += OnShowAbout;
            _view.OnShowChartDefectClick += OnShowChartDefect;
            _view.OnShowReportSalaryClick += OnShowReportSalary;
        }

        public override void Run() {
            _repository?.Load();
            _view?.ShowEmployee(_dm);
            base.Run();
        }

        private void OnExit(object sender, System.EventArgs e) {
            _repository?.Close();
            Application.Exit();
        }

        private void OnSave(object sender, System.EventArgs e) {
            _repository?.Save();
        }

        private void OnFilterChange(object sender, System.EventArgs e) {
            string surname = _view?.GetFilterSurname();
            string name = _view?.GetFilterName();
            string patronymic = _view?.GetFilterPatronymic();
            bool? isAsc = _view?.GetSortAsc();
            bool? isDesc = _view?.GetSortDesc();
            _view?.SetEmployeeFilter(Utils.FilterUtils.Bulder(surname, name, patronymic));

            if (isAsc != null && isDesc != null) {
                if (isAsc == true) {
                    _view?.SetEmployeeSort(SORT_ASC);
                } else if (isDesc == true) {
                    _view?.SetEmployeeSort(SORT_DESC);
                } else {
                    _view?.SetEmployeeSort(null);
                }              
            }

        }

        private void OnShowAbout(object sender, System.EventArgs e) {
            IAboutView view = new Forms.AboutForm(new ApplicationContext());
            IPresenter presenter = new AboutPresenter(view);
            presenter?.Run();
        }

        private void OnShowReportSalary(object sender, System.EventArgs e) {
            IReportSalaryView view = new Forms.SalaryReportForm(new ApplicationContext());
            IPresenter presenter = new SalaryReportPresenter(view);
            presenter?.Run();
        }
        private void OnShowChartDefect(object sender, System.EventArgs e) {
            IChartDefectView view = new Forms.DefectChartForm(new ApplicationContext());
            IPresenter presenter = new DefectChartPresenter(view);
            presenter?.Run();
        }

    }
}
