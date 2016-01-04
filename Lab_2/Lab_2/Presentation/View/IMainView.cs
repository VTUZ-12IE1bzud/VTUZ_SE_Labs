using System;

namespace Lab_2.Presentation.View {
    interface IMainView : IView {

        event EventHandler OnCalculateClick;
        event EventHandler OnCleanClick;
        event EventHandler OnExitClick;

        string GetParamA();
        string GetParamB();
        void ClearParamA();
        void ClearParamB();
        void ShowSumma(string summa);
    }
}
