namespace Lab_5.Presentation.Forms {
    partial class ReportForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.DataBinding_Report = new System.Windows.Forms.BindingSource(this.components);
            this.ReportView_Salary = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataBinding_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportView_Salary
            // 
            reportDataSource1.Name = "DataReport";
            reportDataSource1.Value = this.DataBinding_Report;
            this.ReportView_Salary.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportView_Salary.LocalReport.ReportEmbeddedResource = "Lab_5.Assets.ReportSalary.rdlc";
            resources.ApplyResources(this.ReportView_Salary, "ReportView_Salary");
            this.ReportView_Salary.Name = "ReportView_Salary";
            // 
            // ReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReportView_Salary);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataBinding_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportView_Salary;
        private System.Windows.Forms.BindingSource DataBinding_Report;
    }
}