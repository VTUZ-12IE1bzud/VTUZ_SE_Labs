namespace Lab_7.Presentation.Forms {
    partial class DefectChartForm {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectChartForm));
            this.Chart_Defect = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Binding_ChartDefect = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Defect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Binding_ChartDefect)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_Defect
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_Defect.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_Defect.Legends.Add(legend1);
            resources.ApplyResources(this.Chart_Defect, "Chart_Defect");
            this.Chart_Defect.Name = "Chart_Defect";
            // 
            // DefectChartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Chart_Defect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefectChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Defect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Binding_ChartDefect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Defect;
        private System.Windows.Forms.BindingSource Binding_ChartDefect;
    }
}