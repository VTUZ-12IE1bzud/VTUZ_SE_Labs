using System;
using System.Data;

namespace Lab_7.Presentation.View {
    interface IMainView : IView {

        event EventHandler OnFilterChange;
        event EventHandler OnExitClick;
        event EventHandler OnSaveClick;
        event EventHandler OnShowReportSalaryClick;
        event EventHandler OnShowChartDefectClick;
        event EventHandler OnShowAboutClick;
        event EventHandler OnShowChartSalaryClick;
        event EventHandler OnShowReportDefectClick;


        string GetFilterSurname();
        string GetFilterName();
        string GetFilterPatronymic();
        bool GetSortAsc();
        bool GetSortDesc();

        void ShowEmployee(DataSet data);

        void SetEmployeeFilter(string filter);
        void SetEmployeeSort(string sort);
    }
}
