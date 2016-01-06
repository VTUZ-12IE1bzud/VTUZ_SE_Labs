using System.Windows.Forms;
using Lab_4.Presentation.View;

namespace Lab_4.Presentation.Presenter {
    class MainPresenter : BasePresenter<View.IMainView> {

        private const string DATA_SORT = "surname ASC, name";
        private const string KEY_DATA = "EMPLOYEE";

        public MainPresenter(IMainView view) : base(view) {
            _view.OnFilterChange += OnFilerChange;
        }

        public override void Run() {
            Data.Repository.EmployeeRepository repository = new Data.Repository.EmployeeRepository();
            _view?.ShowEmployee(repository.GetEmployee(KEY_DATA), KEY_DATA);
            _view?.ShowEmployeeSort(DATA_SORT);
            base.Run();
        }

        private void ShowErrMessage(string msg) {
            MessageBox.Show(msg);
        }

        private void OnFilerChange(object sender, System.EventArgs e) {
            string surname = _view?.GetFilterSurname();
            string name = _view?.GetFilterName();
            string patronymic = _view?.GetFilterPatronymic();
            string salary = _view?.GetFilterSalary();
            int iSalary = 0;

            try { iSalary = int.Parse(salary); } catch { ShowErrMessage(ResString.TextErrSalaryNotValidate); }
            _view?.ShowEmployeeFilter(Utils.FilterUtils.Bulder(surname, name, patronymic, iSalary));
        }
    }

}
