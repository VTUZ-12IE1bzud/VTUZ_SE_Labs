using System;
using System.Reflection;
using System.Windows.Forms;
using Lab_7.Presentation.View;

namespace Lab_7.Presentation.Forms {
    partial class AboutForm : Form, View.IAboutView {

        private readonly ApplicationContext _context;

        public AboutForm(ApplicationContext context) {
            _context = context;
            InitializeComponent();
            this.Text = String.Format("О программе {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Версия {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        public new void Show() {
            _context.MainForm = this;
            base.Show();
        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                return ResString.AppName;
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                return ResString.AppDescription;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                return ResString.AppName;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                return ResString.AppCompany;
            }
        }
        #endregion

        private void OnBtnOkClick(object sender, EventArgs e) {
            Close();
        }
    }
}
