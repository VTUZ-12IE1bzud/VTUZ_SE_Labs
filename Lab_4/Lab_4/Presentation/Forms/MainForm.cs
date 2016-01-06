using System;
using System.Data;
using System.Windows.Forms;

namespace Lab_4.Presentation.Forms {
    public partial class MainForm : Form, View.IMainView {

        private readonly ApplicationContext _context;

        public event EventHandler OnFilterChange = delegate { };

        public MainForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public string GetFilterName() {
            return TextBox_Name.Text;
        }

        public string GetFilterPatronymic() {
            return TextBox_Patronymic.Text;
        }

        public string GetFilterSalary() {
            return TextBox_Salary.Text;
        }

        public string GetFilterSurname() {
            return TextBox_Surname.Text;
        }

        public new void Show() {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public void ShowEmployee(DataSet data, string dataKey) {
            DBinding.DataSource = data;
            DBinding.DataMember = dataKey;
        }

        public void ShowEmployeeFilter(string filter) {
            if (filter != null) {
                DBinding.Filter = filter;
            } else {
                DBinding.RemoveFilter();
            }
        }

        public void ShowEmployeeSort(string sort) {
            if (sort != null) {
                DBinding.Sort = sort;
            } else {
                DBinding.RemoveSort();
            }
        }

        private void OnTextBoxSurnameChange(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }

        private void OnTextBoxNameChange(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }

        private void OnTextBoxPatronymicChange(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }

        private void OnTextBoxSalaryChange(object sender, EventArgs e) {
            OnFilterChange(this, EventArgs.Empty);
        }
    }
}
