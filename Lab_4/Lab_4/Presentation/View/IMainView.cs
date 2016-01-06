using System;
using System.Data;

namespace Lab_4.Presentation.View {
    interface IMainView : IView {

        event EventHandler OnFilterChange;
        string GetFilterSurname();
        string GetFilterName();
        string GetFilterPatronymic();
        string GetFilterSalary();

        void ShowEmployeeFilter(string filter);

        void ShowEmployeeSort(string sort);

        void ShowEmployee(DataSet data, string dataKey);

    }
}
