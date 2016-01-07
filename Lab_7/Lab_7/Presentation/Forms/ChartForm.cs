using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_7.Presentation.Forms {
    public partial class ChartForm : Form, View.IChartView {

        private readonly ApplicationContext _context;

        public ChartForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowChart(DataSet ds, string member, string valueX, string valueY, SeriesChartType type) {
            Binding_ChartDefect.DataSource = ds;
            Binding_ChartDefect.DataMember = member;
            Chart_All.DataBindCrossTable(Binding_ChartDefect, valueX, valueX, valueY, "");
            foreach (Series series in Chart_All.Series) {
                series.ChartType = type;
            }
        }
    }
}
