using System;
using System.Data;

namespace Lab_6.Presentation.View {
    interface IMainView : IView {

        event EventHandler OnChartClick;

        void ShowEmployee(DataSet data);

    }
}
