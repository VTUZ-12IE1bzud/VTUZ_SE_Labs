using System;
using System.Data;
using System.Windows.Forms;

namespace Lab_7.Presentation.Forms {
    public partial class SalaryReportForm : Form, View.IReportSalaryView {

        private readonly ApplicationContext _context;

        public SalaryReportForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowReport(DataSet ds) {
            Binding_ReportSalary.DataSource = ds;
            Binding_ReportSalary.DataMember = "ViewEmloyeeSalary";
            ReportView_Salary.RefreshReport();
        }
    }
}
