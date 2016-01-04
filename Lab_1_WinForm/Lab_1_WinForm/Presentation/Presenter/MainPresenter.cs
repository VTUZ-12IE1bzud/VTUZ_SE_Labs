
using Lab_1_WinForm.Presentation.View;

namespace Lab_1_WinForm.Presentation.Presenter {
    class MainPresenter : BasePresenter<View.IMainView> {

        public MainPresenter(IMainView view) : base(view) {
            _view.OnCheckVisibly += OnCheckVisibly;
        }

        public override void Run() {
            _view?.ShowMessage(ResString.Message);
            base.Run();
        }

        private void OnCheckVisibly(object sender, System.EventArgs e) {
            bool isChecked = _view.IsCheckVisibly();
            if (isChecked) {
                _view?.ShowMessage(ResString.Message);
            } else {
                _view?.HideMessage();
            }
            
        }

    }
}
