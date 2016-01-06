using System.Data;
using System.Windows.Forms;

namespace Lab_5.Presentation.Forms {
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

        public void ShowReport(DataSet data) {
            DataBinding_Report.DataSource = data;
            DataBinding_Report.DataMember = "ViewEmloyeeSalary";
            ReportView_Salary.RefreshReport();
        }

    }
}
