using System.Windows.Forms;
using Lab_2.Presentation.View;
using Lab_2.Domain.Interactor;

namespace Lab_2.Presentation.Presenter {
    class MainPresenter : BasePresenter<IMainView> {

        private readonly CalculateCase _calculate;

        public MainPresenter(IMainView view) : base(view) {
            _calculate = new CalculateCase();
            _calculate.OnEvent += new CalculateCase.Handler(OnCalculateEvent);
            _view.OnCalculateClick += OnCalculate;
            _view.OnCleanClick += OnClear;
            _view.OnExitClick += OnExit;
        }

        private void ShowSumma(float result) {
            _view?.ShowSumma(result.ToString());
        }

        private void ShowMessage(string msg) {
            _view?.ShowSumma(msg);
        }

        private void OnCalculate(object sender, System.EventArgs e) {
            _calculate?.Run(_view?.GetParamA(), _view?.GetParamB());
        }

        private void OnClear(object sender, System.EventArgs e) {
            _view?.ClearParamA();
            _view?.ClearParamB();
            _view?.ShowSumma(null);
        }

        private void OnExit(object sender, System.EventArgs e) {
            Application.Exit();
        }

        private void OnCalculateEvent(object Sender, CalculateCase.CalculateEventArgs e) {
            switch (e.State) {
                case CalculateCase.State.SUCCESS:
                    ShowSumma(e.Summa);
                    break;
                case CalculateCase.State.ERROR:
                    ShowMessage(ResString.TextErrParamValue);
                    break;
                default: break;
            }
        }
    }
}
