using System.Data;

namespace Lab_7.Presentation.View {
    interface IChartDefectView : IView {

        void ShowChart(DataSet ds);

    }
}
