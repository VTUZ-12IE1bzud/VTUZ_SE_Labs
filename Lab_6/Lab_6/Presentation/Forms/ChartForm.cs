using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_6.Presentation.Forms {
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

        public void ShowChart(DataSet data) {
            DataBinding_Salary.DataSource = data;
            DataBinding_Salary.DataMember = "ViewEmloyeeSalary";
            Chart_Salary.DataBindCrossTable(DataBinding_Salary, "surname", "surname", "summa", "");
        }

    }
}
