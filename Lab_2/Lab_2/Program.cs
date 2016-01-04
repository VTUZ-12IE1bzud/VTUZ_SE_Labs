using System;
using System.Windows.Forms;

namespace Lab_2 {
    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Presentation.View.IMainView mainView = new Presentation.Forms.MainForm(new ApplicationContext());
            IPresenter mainPresenter = new Presentation.Presenter.MainPresenter(mainView);

            mainPresenter?.Run();
        }
    }
}
