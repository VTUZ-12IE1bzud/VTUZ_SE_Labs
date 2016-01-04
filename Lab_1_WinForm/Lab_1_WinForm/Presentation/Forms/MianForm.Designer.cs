namespace Lab_1_WinForm.Presentation.Forms {
    partial class MianForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MianForm));
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.CheckBoxVisible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TextBoxMessage
            // 
            resources.ApplyResources(this.TextBoxMessage, "TextBoxMessage");
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ReadOnly = true;
            // 
            // CheckBoxVisible
            // 
            resources.ApplyResources(this.CheckBoxVisible, "CheckBoxVisible");
            this.CheckBoxVisible.Checked = true;
            this.CheckBoxVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxVisible.Name = "CheckBoxVisible";
            this.CheckBoxVisible.UseVisualStyleBackColor = true;
            this.CheckBoxVisible.CheckedChanged += new System.EventHandler(this.OnCheckedChangedListener);
            // 
            // MianForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheckBoxVisible);
            this.Controls.Add(this.TextBoxMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MianForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.CheckBox CheckBoxVisible;
    }
}