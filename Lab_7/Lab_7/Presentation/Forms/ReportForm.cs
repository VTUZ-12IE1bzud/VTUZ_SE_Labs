using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Lab_7.Presentation.Forms {
    public partial class ReportForm : Form, View.IReportView {

        private readonly ApplicationContext _context;

        public ReportForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowReport(DataSet ds, string member, string reportPath, string dataParamName) {
            ReportView_All.LocalReport.ReportEmbeddedResource = reportPath;
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = dataParamName;
            reportDataSource.Value = Binding_ReportSalary;
            ReportView_All.LocalReport.DataSources.Add(reportDataSource);
            Binding_ReportSalary.DataSource = ds;
            Binding_ReportSalary.DataMember = member;
            ReportView_All.RefreshReport();
        }
    }
}
