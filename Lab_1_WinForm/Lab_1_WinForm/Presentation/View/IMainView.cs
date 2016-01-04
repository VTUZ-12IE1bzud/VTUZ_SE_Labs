
using System;

namespace Lab_1_WinForm.Presentation.View {
    public interface IMainView : IView {

        event EventHandler OnCheckVisibly;

        void ShowMessage(string msg);

        void HideMessage();

        bool IsCheckVisibly();

    }
}
