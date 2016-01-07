using System.Data;

namespace Lab_7.Presentation.View {
    interface IReportSalaryView : IView {

        void ShowReport(DataSet ds);

    }
}
