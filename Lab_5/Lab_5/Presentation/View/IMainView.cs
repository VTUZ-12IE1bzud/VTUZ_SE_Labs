using System;
using System.Data;

namespace Lab_5.Presentation.View {
    interface IMainView : IView {

        event EventHandler OnReportClick;

        void ShowEmployee(DataSet data);

    }
}
