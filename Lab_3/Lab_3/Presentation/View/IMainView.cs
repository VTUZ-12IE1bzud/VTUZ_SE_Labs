using System;

namespace Lab_3.Presentation.View {

    interface IMainView : IView {

        event EventHandler OnCloseClick;
        Data.Adapter.DataManager DataManager { get; }

    }
}
