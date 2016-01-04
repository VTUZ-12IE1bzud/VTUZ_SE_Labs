using System;
using System.Windows.Forms;

namespace Lab_2.Presentation.Forms {
    public partial class MainForm : Form, Presentation.View.IMainView {

        private readonly ApplicationContext _context;
        public event EventHandler OnCalculateClick = delegate { };
        public event EventHandler OnCleanClick = delegate { };
        public event EventHandler OnExitClick = delegate { };

        public MainForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public string GetParamA() {
            return TxtboxParamA.Text;
        }

        public string GetParamB() {
            return TxtboxParamB.Text;
        }

        public void ShowSumma(string summa) {
            if (summa != null) {
                TxtboxSumma.Text = summa;
            } else {
                TxtboxSumma.Clear();
            }
        }

        private void OnBtnClearClick(object sender, EventArgs e) {
            OnCleanClick(this, EventArgs.Empty);
        }

        private void OnBtnCalculateClick(object sender, EventArgs e) {
            OnCalculateClick(this, EventArgs.Empty);
        }

        private void OnLabelExitClick(object sender, EventArgs e) {
            OnExitClick(this, EventArgs.Empty);
        }

        public void ClearParamA() {
            TxtboxParamA.Clear();
        }

        public void ClearParamB() {
            TxtboxParamB.Clear();
        }
    }
}
