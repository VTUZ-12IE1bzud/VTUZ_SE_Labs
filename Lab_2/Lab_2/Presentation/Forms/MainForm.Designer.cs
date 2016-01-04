namespace Lab_2.Presentation.Forms {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TxtboxParamA = new System.Windows.Forms.TextBox();
            this.TxtboxParamB = new System.Windows.Forms.TextBox();
            this.TxtboxSumma = new System.Windows.Forms.TextBox();
            this.LabelDenominator = new System.Windows.Forms.Label();
            this.LabelMinus = new System.Windows.Forms.Label();
            this.LabelAnyway = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LabelExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtboxParamA
            // 
            resources.ApplyResources(this.TxtboxParamA, "TxtboxParamA");
            this.TxtboxParamA.Name = "TxtboxParamA";
            // 
            // TxtboxParamB
            // 
            resources.ApplyResources(this.TxtboxParamB, "TxtboxParamB");
            this.TxtboxParamB.Name = "TxtboxParamB";
            // 
            // TxtboxSumma
            // 
            resources.ApplyResources(this.TxtboxSumma, "TxtboxSumma");
            this.TxtboxSumma.Name = "TxtboxSumma";
            this.TxtboxSumma.ReadOnly = true;
            // 
            // LabelDenominator
            // 
            resources.ApplyResources(this.LabelDenominator, "LabelDenominator");
            this.LabelDenominator.Name = "LabelDenominator";
            // 
            // LabelMinus
            // 
            resources.ApplyResources(this.LabelMinus, "LabelMinus");
            this.LabelMinus.Name = "LabelMinus";
            // 
            // LabelAnyway
            // 
            resources.ApplyResources(this.LabelAnyway, "LabelAnyway");
            this.LabelAnyway.Name = "LabelAnyway";
            // 
            // BtnClear
            // 
            resources.ApplyResources(this.BtnClear, "BtnClear");
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.OnBtnClearClick);
            // 
            // BtnCalculate
            // 
            resources.ApplyResources(this.BtnCalculate, "BtnCalculate");
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.OnBtnCalculateClick);
            // 
            // LabelExit
            // 
            resources.ApplyResources(this.LabelExit, "LabelExit");
            this.LabelExit.ForeColor = System.Drawing.Color.Red;
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Click += new System.EventHandler(this.OnLabelExitClick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelExit);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LabelAnyway);
            this.Controls.Add(this.LabelMinus);
            this.Controls.Add(this.LabelDenominator);
            this.Controls.Add(this.TxtboxSumma);
            this.Controls.Add(this.TxtboxParamB);
            this.Controls.Add(this.TxtboxParamA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtboxParamA;
        private System.Windows.Forms.TextBox TxtboxParamB;
        private System.Windows.Forms.TextBox TxtboxSumma;
        private System.Windows.Forms.Label LabelDenominator;
        private System.Windows.Forms.Label LabelMinus;
        private System.Windows.Forms.Label LabelAnyway;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label LabelExit;
    }
}

