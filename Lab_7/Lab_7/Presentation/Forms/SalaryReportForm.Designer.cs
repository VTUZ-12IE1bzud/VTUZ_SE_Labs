namespace Lab_7.Presentation.Forms {
    partial class SalaryReportForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryReportForm));
            this.Binding_ReportSalary = new System.Windows.Forms.BindingSource(this.components);
            this.ReportView_Salary = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Binding_ReportSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportView_Salary
            // 
            reportDataSource1.Name = "DataReportSalary";
            reportDataSource1.Value = this.Binding_ReportSalary;
            this.ReportView_Salary.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportView_Salary.LocalReport.ReportEmbeddedResource = "Lab_7.Assets.ReportSalary.rdlc";
            resources.ApplyResources(this.ReportView_Salary, "ReportView_Salary");
            this.ReportView_Salary.Name = "ReportView_Salary";
            // 
            // SalaryReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReportView_Salary);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalaryReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.Binding_ReportSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportView_Salary;
        private System.Windows.Forms.BindingSource Binding_ReportSalary;
    }
}