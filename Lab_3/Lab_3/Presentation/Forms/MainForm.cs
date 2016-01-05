using System;
using System.Windows.Forms;
using Lab_3.Data.Adapter;

namespace Lab_3.Presentation.Forms {
    public partial class MainForm : Form, View.IMainView {

        private readonly ApplicationContext _context;
        public event EventHandler OnCloseClick = delegate { };

        public MainForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            Application.Run(_context);
        }


        public DataManager DataManager {
            get { return Data; }
        }

        private void OnClosingClick(object sender, FormClosingEventArgs e) {
            OnCloseClick(this, EventArgs.Empty);
        }
    }
}
