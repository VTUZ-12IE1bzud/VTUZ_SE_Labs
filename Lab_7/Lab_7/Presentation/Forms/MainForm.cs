using System;
using System.Data;
using System.Windows.Forms;

namespace Lab_7.Presentation.Forms {
    public partial class MainForm : Form, View.IMainView {

        private readonly ApplicationContext _context;
        public event EventHandler OnFilterChange = delegate { };
        public event EventHandler OnExitClick = delegate { };
        public event EventHandler OnSaveClick = delegate { };
        public event EventHandler OnShowReportSalaryClick = delegate { };
        public event EventHandler OnShowChartDefectClick = delegate { };
        public event EventHandler OnShowAboutClick = delegate { };

        public MainForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public void ShowEmployee(DataSet data) {
            Binding_Employee.DataSource = data;
            Binding_Employee.DataMember = "Employee";
            Binding_EmployeeJob.DataSource = Binding_Employee;
            Binding_EmployeeJob.DataMember = "EmployeeJob";
        }

        public void SetEmployeeFilter(string filter) {
            if (filter != null) {
                Binding_Employee.Filter = filter;
            } else {
                Binding_Employee.RemoveFilter();
            }
        }

        public void SetEmployeeSort(string sort) {
            if (sort != null) {
                Binding_Employee.Sort = sort;
            } else {
                Binding_Employee.RemoveSort();
            }
        }

        public string GetFilterSurname() {
            return TextBox_FilterSurname.Text;
        }

        public string GetFilterName() {
            return TextBox_FilterName.Text;
        }

        public string GetFilterPatronymic() {
            return TextBox_FilterPatronymic.Text;
        }

        public bool GetSortAsc() {
            return RadioBtn_SortASC.Checked;
        }

        public bool GetSortDesc() {
            return RadioBtn_SortDesc.Checked;
        }

        private void OnMenuItemAboutClick(object sender, EventArgs e) {
            OnShowAboutClick(this, EventArgs.Empty);
        }

        private void OnMenuItemReportSalaryClick(object sender, EventArgs e) {
            OnShowReportSalaryClick(this, EventArgs.Empty);
        }

        private void OnMenuItemChartDefectClick(object sender, EventArgs e) {
            OnShowChartDefectClick(this, EventArgs.Empty);
        }

        private void OnMenuItemSaveClick(object sender, EventArgs e) {
            OnSaveClick(this, EventArgs.Empty);
        }

        private void OnMenuItemExitClick(object sender, EventArgs e) {
            OnExitClick(this, EventArgs.Empty);
        }

        private void OnTextBoxFilterSurnameChange(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }

        private void OnTextBoxFilterNameChange(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }

        private void OnTextBoxFilterPatronymicChange(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }

        private void OnRadioBtnSortDescChecked(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }

        private void OnRadioBtnSortAscChecked(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }
    }
}
