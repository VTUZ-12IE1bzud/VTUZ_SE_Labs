using System;
using System.Windows.Forms;

namespace Lab_1_WinForm.Presentation.Forms {

    public partial class MianForm : Form, View.IMainView {

        private readonly ApplicationContext _context;
        public event EventHandler OnCheckVisibly = delegate { };

        public MianForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
        }

        public new void Show() {
            _context.MainForm = this;
            Application.Run(_context);
        }

     
        public void HideMessage() {
            TextBoxMessage.Visible = false;
        }

        public void ShowMessage(string msg) {
            if (msg != null) {
                TextBoxMessage.Visible = true;
                TextBoxMessage.Text = msg;
            }
        }

        public bool IsCheckVisibly() {
            return CheckBoxVisible.Checked;
        }

        private void OnCheckedChangedListener(object sender, EventArgs e) {
            OnCheckVisibly(this, EventArgs.Empty);
        }

    }
}
