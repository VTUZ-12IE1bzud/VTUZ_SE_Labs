namespace Lab_6.Presentation.Forms {
    partial class ChartForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Chart_Salary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataBinding_Salary = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBinding_Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_Salary
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_Salary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_Salary.Legends.Add(legend1);
            resources.ApplyResources(this.Chart_Salary, "Chart_Salary");
            this.Chart_Salary.Name = "Chart_Salary";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_Salary.Series.Add(series1);
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Зарплата";
            this.Chart_Salary.Titles.Add(title1);
            // 
            // ChartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Chart_Salary);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBinding_Salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Salary;
        private System.Windows.Forms.BindingSource DataBinding_Salary;
    }
}