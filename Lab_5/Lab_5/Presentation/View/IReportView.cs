using System.Data;

namespace Lab_5.Presentation.View {
    interface IReportView :IView {

        void ShowReport(DataSet data);

    }
}
