namespace Lab_3.Presentation.Forms {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridEmployee = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingData = new System.Windows.Forms.BindingSource(this.components);
            this.Data = new Lab_3.Data.Adapter.DataManager();
            this.NavigatorEmployee = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeTableAdapter = new Lab_3.Data.Adapter.DataManagerTableAdapters.EmployeeTableAdapter();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPatronymic = new System.Windows.Forms.TextBox();
            this.DataGridJob = new System.Windows.Forms.DataGridView();
            this.employeeJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new Lab_3.Data.Adapter.DataManagerTableAdapters.JobTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavigatorJob = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorEmployee)).BeginInit();
            this.NavigatorEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorJob)).BeginInit();
            this.NavigatorJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxPatronymic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxSurname);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DataGridEmployee
            // 
            this.DataGridEmployee.AllowUserToAddRows = false;
            this.DataGridEmployee.AllowUserToDeleteRows = false;
            this.DataGridEmployee.AllowUserToResizeColumns = false;
            this.DataGridEmployee.AllowUserToResizeRows = false;
            this.DataGridEmployee.AutoGenerateColumns = false;
            this.DataGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn});
            this.DataGridEmployee.DataSource = this.employeeBindingSource;
            resources.ApplyResources(this.DataGridEmployee, "DataGridEmployee");
            this.DataGridEmployee.MultiSelect = false;
            this.DataGridEmployee.Name = "DataGridEmployee";
            this.DataGridEmployee.ReadOnly = true;
            this.DataGridEmployee.RowHeadersVisible = false;
            this.DataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.BindingData;
            // 
            // BindingData
            // 
            this.BindingData.DataSource = this.Data;
            this.BindingData.Position = 0;
            // 
            // Data
            // 
            this.Data.DataSetName = "DataManager";
            this.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NavigatorEmployee
            // 
            this.NavigatorEmployee.AddNewItem = this.bindingNavigatorAddNewItem;
            this.NavigatorEmployee.BindingSource = this.employeeBindingSource;
            this.NavigatorEmployee.CountItem = this.bindingNavigatorCountItem;
            this.NavigatorEmployee.DeleteItem = this.bindingNavigatorDeleteItem;
            this.NavigatorEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            resources.ApplyResources(this.NavigatorEmployee, "NavigatorEmployee");
            this.NavigatorEmployee.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.NavigatorEmployee.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.NavigatorEmployee.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.NavigatorEmployee.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.NavigatorEmployee.Name = "NavigatorEmployee";
            this.NavigatorEmployee.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "surname", true));
            resources.ApplyResources(this.TextBoxSurname, "TextBoxSurname");
            this.TextBoxSurname.Name = "TextBoxSurname";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TextBoxName
            // 
            this.TextBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "name", true));
            resources.ApplyResources(this.TextBoxName, "TextBoxName");
            this.TextBoxName.Name = "TextBoxName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TextBoxPatronymic
            // 
            this.TextBoxPatronymic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "patronymic", true));
            resources.ApplyResources(this.TextBoxPatronymic, "TextBoxPatronymic");
            this.TextBoxPatronymic.Name = "TextBoxPatronymic";
            // 
            // DataGridJob
            // 
            this.DataGridJob.AllowUserToAddRows = false;
            this.DataGridJob.AllowUserToDeleteRows = false;
            this.DataGridJob.AllowUserToResizeColumns = false;
            this.DataGridJob.AllowUserToResizeRows = false;
            this.DataGridJob.AutoGenerateColumns = false;
            this.DataGridJob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.employeeIdDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.defectDataGridViewTextBoxColumn});
            this.DataGridJob.DataSource = this.employeeJobBindingSource;
            resources.ApplyResources(this.DataGridJob, "DataGridJob");
            this.DataGridJob.MultiSelect = false;
            this.DataGridJob.Name = "DataGridJob";
            this.DataGridJob.RowHeadersVisible = false;
            // 
            // employeeJobBindingSource
            // 
            this.employeeJobBindingSource.DataMember = "EmployeeJob";
            this.employeeJobBindingSource.DataSource = this.employeeBindingSource;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn1, "idDataGridViewTextBoxColumn1");
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "employeeId";
            resources.ApplyResources(this.employeeIdDataGridViewTextBoxColumn, "employeeIdDataGridViewTextBoxColumn");
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "tariff";
            resources.ApplyResources(this.tariffDataGridViewTextBoxColumn, "tariffDataGridViewTextBoxColumn");
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            resources.ApplyResources(this.amountDataGridViewTextBoxColumn, "amountDataGridViewTextBoxColumn");
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // defectDataGridViewTextBoxColumn
            // 
            this.defectDataGridViewTextBoxColumn.DataPropertyName = "defect";
            resources.ApplyResources(this.defectDataGridViewTextBoxColumn, "defectDataGridViewTextBoxColumn");
            this.defectDataGridViewTextBoxColumn.Name = "defectDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            resources.ApplyResources(this.surnameDataGridViewTextBoxColumn, "surnameDataGridViewTextBoxColumn");
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            resources.ApplyResources(this.patronymicDataGridViewTextBoxColumn, "patronymicDataGridViewTextBoxColumn");
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NavigatorJob
            // 
            this.NavigatorJob.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.NavigatorJob.BindingSource = this.employeeJobBindingSource;
            this.NavigatorJob.CountItem = this.bindingNavigatorCountItem1;
            this.NavigatorJob.DeleteItem = this.bindingNavigatorDeleteItem1;
            resources.ApplyResources(this.NavigatorJob, "NavigatorJob");
            this.NavigatorJob.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.NavigatorJob.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.NavigatorJob.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.NavigatorJob.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.NavigatorJob.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.NavigatorJob.Name = "NavigatorJob";
            this.NavigatorJob.PositionItem = this.bindingNavigatorPositionItem1;
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem1, "bindingNavigatorMoveFirstItem1");
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem1, "bindingNavigatorMovePreviousItem1");
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator3, "bindingNavigatorSeparator3");
            // 
            // bindingNavigatorPositionItem1
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem1, "bindingNavigatorPositionItem1");
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem1, "bindingNavigatorCountItem1");
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator4, "bindingNavigatorSeparator4");
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem1, "bindingNavigatorMoveNextItem1");
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem1, "bindingNavigatorMoveLastItem1");
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator5, "bindingNavigatorSeparator5");
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem1, "bindingNavigatorAddNewItem1");
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorDeleteItem1, "bindingNavigatorDeleteItem1");
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NavigatorJob);
            this.Controls.Add(this.DataGridJob);
            this.Controls.Add(this.NavigatorEmployee);
            this.Controls.Add(this.DataGridEmployee);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosingClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorEmployee)).EndInit();
            this.NavigatorEmployee.ResumeLayout(false);
            this.NavigatorEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorJob)).EndInit();
            this.NavigatorJob.ResumeLayout(false);
            this.NavigatorJob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridEmployee;
        private System.Windows.Forms.BindingNavigator NavigatorEmployee;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource BindingData;
        private Data.Adapter.DataManager Data;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Data.Adapter.DataManagerTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.TextBox TextBoxPatronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridJob;
        private System.Windows.Forms.BindingSource employeeJobBindingSource;
        private Data.Adapter.DataManagerTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator NavigatorJob;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    }
}