using System;
using System.Data;
using System.Windows.Forms;

namespace Lab_5.Presentation.Forms {
    public partial class MainForm : Form, View.IMainView {

        private readonly ApplicationContext _context;
        public event EventHandler OnReportClick = delegate { };

        public MainForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public void ShowEmployee(DataSet data) {
            DataBinding_Employee.DataSource = data;
            DataBinding_Employee.DataMember = "Employee";
            DataBinding_Job.DataSource = DataBinding_Employee;
            DataBinding_Job.DataMember = "EmployeeJob";
        }

        private void OnBtnReportClick(object sender, EventArgs e) {
            OnReportClick(this, EventArgs.Empty);
        }
    }
}
