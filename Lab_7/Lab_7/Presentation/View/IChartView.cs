using System.Data;

namespace Lab_7.Presentation.View {
    interface IChartView : IView {

        void ShowChart(DataSet ds, string member, string valueX, string valueY, 
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType type);

    }
}
