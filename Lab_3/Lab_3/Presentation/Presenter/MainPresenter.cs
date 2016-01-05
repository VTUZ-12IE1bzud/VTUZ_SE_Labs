using System.Windows.Forms;
using Lab_3.Presentation.View;

namespace Lab_3.Presentation.Presenter {
    class MainPresenter : BasePresenter<View.IMainView> {
        public MainPresenter(IMainView view) : base(view) {
            _view.OnCloseClick += OnExit;
        }

        public override void Run() {
            Data.Repository.EmployeeRepository employee
                = new Data.Repository.EmployeeRepository(_view?.DataManager);
            employee.Load();
            Data.Repository.JobRepository job
                = new Data.Repository.JobRepository(_view?.DataManager);
            job.Load();
            base.Run();
        }

        private void OnSaveClose() {
            Data.Repository.EmployeeRepository employee
                 = new Data.Repository.EmployeeRepository(_view?.DataManager);
            Data.Repository.JobRepository job
                = new Data.Repository.JobRepository(_view?.DataManager);
            employee.Save();
            job.Save();
            employee.Close();
            job.Close();
        }

        private void OnExit(object sender, System.EventArgs e) {
            OnSaveClose();
            Application.Exit();
        }

    }
}
