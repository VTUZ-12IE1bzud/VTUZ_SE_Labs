using System.Data;

namespace Lab_7.Presentation.View {
    interface IReportView : IView {

        void ShowReport(DataSet ds, string member, string reportPath, string dataParamName);

    }
}
