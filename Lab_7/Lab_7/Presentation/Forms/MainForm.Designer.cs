namespace Lab_7.Presentation.Forms {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ReportSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ChartDefect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioBtn_SortDesc = new System.Windows.Forms.RadioButton();
            this.RadioBtn_SortASC = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_FilterPatronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_FilterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_FilterSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGrid_Employee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Binding_Employee = new System.Windows.Forms.BindingSource(this.components);
            this.Navigator_Employee = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGrid_EmployeeJob = new System.Windows.Forms.DataGridView();
            this.Binding_EmployeeJob = new System.Windows.Forms.BindingSource(this.components);
            this.Navigator_EmployeeJob = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Binding_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator_Employee)).BeginInit();
            this.Navigator_Employee.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_EmployeeJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Binding_EmployeeJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator_EmployeeJob)).BeginInit();
            this.Navigator_EmployeeJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ыToolStripMenuItem,
            this.графикToolStripMenuItem,
            this.MenuItem_About});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Save,
            this.toolStripSeparator1,
            this.MenuItem_Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Name = "MenuItem_Save";
            resources.ApplyResources(this.MenuItem_Save, "MenuItem_Save");
            this.MenuItem_Save.Click += new System.EventHandler(this.OnMenuItemSaveClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            resources.ApplyResources(this.MenuItem_Exit, "MenuItem_Exit");
            this.MenuItem_Exit.Click += new System.EventHandler(this.OnMenuItemExitClick);
            // 
            // ыToolStripMenuItem
            // 
            this.ыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ReportSalary});
            this.ыToolStripMenuItem.Name = "ыToolStripMenuItem";
            resources.ApplyResources(this.ыToolStripMenuItem, "ыToolStripMenuItem");
            // 
            // MenuItem_ReportSalary
            // 
            this.MenuItem_ReportSalary.Name = "MenuItem_ReportSalary";
            resources.ApplyResources(this.MenuItem_ReportSalary, "MenuItem_ReportSalary");
            this.MenuItem_ReportSalary.Click += new System.EventHandler(this.OnMenuItemReportSalaryClick);
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ChartDefect});
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            resources.ApplyResources(this.графикToolStripMenuItem, "графикToolStripMenuItem");
            // 
            // MenuItem_ChartDefect
            // 
            this.MenuItem_ChartDefect.Name = "MenuItem_ChartDefect";
            resources.ApplyResources(this.MenuItem_ChartDefect, "MenuItem_ChartDefect");
            this.MenuItem_ChartDefect.Click += new System.EventHandler(this.OnMenuItemChartDefectClick);
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            resources.ApplyResources(this.MenuItem_About, "MenuItem_About");
            this.MenuItem_About.Click += new System.EventHandler(this.OnMenuItemAboutClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.DataGrid_Employee);
            this.groupBox1.Controls.Add(this.Navigator_Employee);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioBtn_SortDesc);
            this.groupBox2.Controls.Add(this.RadioBtn_SortASC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextBox_FilterPatronymic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextBox_FilterName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TextBox_FilterSurname);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // RadioBtn_SortDesc
            // 
            resources.ApplyResources(this.RadioBtn_SortDesc, "RadioBtn_SortDesc");
            this.RadioBtn_SortDesc.Name = "RadioBtn_SortDesc";
            this.RadioBtn_SortDesc.UseVisualStyleBackColor = true;
            this.RadioBtn_SortDesc.CheckedChanged += new System.EventHandler(this.OnRadioBtnSortDescChecked);
            // 
            // RadioBtn_SortASC
            // 
            resources.ApplyResources(this.RadioBtn_SortASC, "RadioBtn_SortASC");
            this.RadioBtn_SortASC.Name = "RadioBtn_SortASC";
            this.RadioBtn_SortASC.UseVisualStyleBackColor = true;
            this.RadioBtn_SortASC.CheckedChanged += new System.EventHandler(this.OnRadioBtnSortAscChecked);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TextBox_FilterPatronymic
            // 
            resources.ApplyResources(this.TextBox_FilterPatronymic, "TextBox_FilterPatronymic");
            this.TextBox_FilterPatronymic.Name = "TextBox_FilterPatronymic";
            this.TextBox_FilterPatronymic.TextChanged += new System.EventHandler(this.OnTextBoxFilterPatronymicChange);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TextBox_FilterName
            // 
            resources.ApplyResources(this.TextBox_FilterName, "TextBox_FilterName");
            this.TextBox_FilterName.Name = "TextBox_FilterName";
            this.TextBox_FilterName.TextChanged += new System.EventHandler(this.OnTextBoxFilterNameChange);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TextBox_FilterSurname
            // 
            resources.ApplyResources(this.TextBox_FilterSurname, "TextBox_FilterSurname");
            this.TextBox_FilterSurname.Name = "TextBox_FilterSurname";
            this.TextBox_FilterSurname.TextChanged += new System.EventHandler(this.OnTextBoxFilterSurnameChange);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DataGrid_Employee
            // 
            this.DataGrid_Employee.AllowUserToAddRows = false;
            this.DataGrid_Employee.AllowUserToDeleteRows = false;
            this.DataGrid_Employee.AllowUserToResizeColumns = false;
            this.DataGrid_Employee.AllowUserToResizeRows = false;
            this.DataGrid_Employee.AutoGenerateColumns = false;
            this.DataGrid_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGrid_Employee.DataSource = this.Binding_Employee;
            resources.ApplyResources(this.DataGrid_Employee, "DataGrid_Employee");
            this.DataGrid_Employee.Name = "DataGrid_Employee";
            this.DataGrid_Employee.RowHeadersVisible = false;
            this.DataGrid_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "surname";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "patronymic";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Navigator_Employee
            // 
            this.Navigator_Employee.AddNewItem = this.bindingNavigatorAddNewItem;
            this.Navigator_Employee.BindingSource = this.Binding_Employee;
            this.Navigator_Employee.CountItem = this.bindingNavigatorCountItem;
            this.Navigator_Employee.DeleteItem = this.bindingNavigatorDeleteItem;
            this.Navigator_Employee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            resources.ApplyResources(this.Navigator_Employee, "Navigator_Employee");
            this.Navigator_Employee.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Navigator_Employee.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Navigator_Employee.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Navigator_Employee.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Navigator_Employee.Name = "Navigator_Employee";
            this.Navigator_Employee.PositionItem = this.bindingNavigatorPositionItem;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataGrid_EmployeeJob);
            this.groupBox3.Controls.Add(this.Navigator_EmployeeJob);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // DataGrid_EmployeeJob
            // 
            this.DataGrid_EmployeeJob.AllowUserToAddRows = false;
            this.DataGrid_EmployeeJob.AllowUserToDeleteRows = false;
            this.DataGrid_EmployeeJob.AllowUserToResizeColumns = false;
            this.DataGrid_EmployeeJob.AllowUserToResizeRows = false;
            this.DataGrid_EmployeeJob.AutoGenerateColumns = false;
            this.DataGrid_EmployeeJob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_EmployeeJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_EmployeeJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGrid_EmployeeJob.DataSource = this.Binding_EmployeeJob;
            resources.ApplyResources(this.DataGrid_EmployeeJob, "DataGrid_EmployeeJob");
            this.DataGrid_EmployeeJob.Name = "DataGrid_EmployeeJob";
            this.DataGrid_EmployeeJob.RowHeadersVisible = false;
            this.DataGrid_EmployeeJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Navigator_EmployeeJob
            // 
            this.Navigator_EmployeeJob.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.Navigator_EmployeeJob.BindingSource = this.Binding_EmployeeJob;
            this.Navigator_EmployeeJob.CountItem = this.bindingNavigatorCountItem1;
            this.Navigator_EmployeeJob.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.Navigator_EmployeeJob.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            resources.ApplyResources(this.Navigator_EmployeeJob, "Navigator_EmployeeJob");
            this.Navigator_EmployeeJob.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.Navigator_EmployeeJob.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.Navigator_EmployeeJob.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.Navigator_EmployeeJob.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.Navigator_EmployeeJob.Name = "Navigator_EmployeeJob";
            this.Navigator_EmployeeJob.PositionItem = this.bindingNavigatorPositionItem1;
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem1, "bindingNavigatorAddNewItem1");
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            resources.ApplyResources(this.bindingNavigatorCountItem1, "bindingNavigatorCountItem1");
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorDeleteItem1, "bindingNavigatorDeleteItem1");
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem1, "bindingNavigatorMoveFirstItem1");
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem1, "bindingNavigatorMovePreviousItem1");
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            resources.ApplyResources(this.bindingNavigatorSeparator3, "bindingNavigatorSeparator3");
            // 
            // bindingNavigatorPositionItem1
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem1, "bindingNavigatorPositionItem1");
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            resources.ApplyResources(this.bindingNavigatorSeparator4, "bindingNavigatorSeparator4");
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem1, "bindingNavigatorMoveNextItem1");
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem1, "bindingNavigatorMoveLastItem1");
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            resources.ApplyResources(this.bindingNavigatorSeparator5, "bindingNavigatorSeparator5");
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tariff";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "amount";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "defect";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Binding_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator_Employee)).EndInit();
            this.Navigator_Employee.ResumeLayout(false);
            this.Navigator_Employee.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_EmployeeJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Binding_EmployeeJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator_EmployeeJob)).EndInit();
            this.Navigator_EmployeeJob.ResumeLayout(false);
            this.Navigator_EmployeeJob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem ыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ReportSalary;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ChartDefect;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_FilterSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrid_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.BindingSource Binding_Employee;
        private System.Windows.Forms.BindingNavigator Navigator_Employee;
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
        private System.Windows.Forms.TextBox TextBox_FilterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_FilterPatronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioBtn_SortDesc;
        private System.Windows.Forms.RadioButton RadioBtn_SortASC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataGrid_EmployeeJob;
        private System.Windows.Forms.BindingNavigator Navigator_EmployeeJob;
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
        private System.Windows.Forms.BindingSource Binding_EmployeeJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}