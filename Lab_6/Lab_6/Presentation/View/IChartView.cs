using System.Data;

namespace Lab_6.Presentation.View {
    interface IChartView : IView {
        void ShowChart(DataSet data);
    }
}
