using System;
using System.Windows.Forms;

namespace Lab_1_WinForm {
    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Presentation.View.IMainView mainView = new Presentation.Forms.MianForm(new ApplicationContext());
            IPresenter mainPresenter = new Presentation.Presenter.MainPresenter(mainView);

            mainPresenter?.Run();
        }
    }
}
