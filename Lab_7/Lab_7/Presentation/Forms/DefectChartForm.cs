using System;
using System.Data;
using System.Windows.Forms;

namespace Lab_7.Presentation.Forms {
    public partial class DefectChartForm : Form, View.IChartDefectView {

        private readonly ApplicationContext _context;

        public DefectChartForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowChart(DataSet ds) {
            Binding_ChartDefect.DataSource = ds;
            Binding_ChartDefect.DataMember = "ViewEmployeeDefect";
            Chart_Defect.DataBindCrossTable(Binding_ChartDefect, "surname", "surname", "defect", "");
        }
    }
}
