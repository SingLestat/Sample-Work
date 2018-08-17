namespace DataBase
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label eMPL_IDLabel;
            System.Windows.Forms.Label eMPL_FNAMELabel;
            System.Windows.Forms.Label eMPL_LNAMELabel;
            System.Windows.Forms.Label eMPL_LAST_UPDATELabel;
            System.Windows.Forms.Label eMPL_CREATE_DATELabel;
            System.Windows.Forms.Label eMPL_ADDRESSLabel;
            System.Windows.Forms.Label eMPL_STATELabel;
            this.employeesDataSet = new DataBase.EmployeesDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new DataBase.EmployeesDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new DataBase.EmployeesDataSetTableAdapters.TableAdapterManager();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.employeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eMPL_IDTextBox = new System.Windows.Forms.TextBox();
            this.eMPL_FNAMETextBox = new System.Windows.Forms.TextBox();
            this.eMPL_LNAMETextBox = new System.Windows.Forms.TextBox();
            this.eMPL_LAST_UPDATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eMPL_CREATE_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eMPL_ADDRESSTextBox = new System.Windows.Forms.TextBox();
            this.eMPL_STATETextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_JOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEE_JOBSTableAdapter = new DataBase.EmployeesDataSetTableAdapters.EMPLOYEE_JOBSTableAdapter();
            eMPL_IDLabel = new System.Windows.Forms.Label();
            eMPL_FNAMELabel = new System.Windows.Forms.Label();
            eMPL_LNAMELabel = new System.Windows.Forms.Label();
            eMPL_LAST_UPDATELabel = new System.Windows.Forms.Label();
            eMPL_CREATE_DATELabel = new System.Windows.Forms.Label();
            eMPL_ADDRESSLabel = new System.Windows.Forms.Label();
            eMPL_STATELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_JOBSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDataSet
            // 
            this.employeesDataSet.DataSetName = "EmployeesDataSet";
            this.employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeesDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLOYEE_JOBSTableAdapter = this.eMPLOYEE_JOBSTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.JobsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.EmployeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.employeesBindingNavigatorSaveItem});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(430, 25);
            this.employeesBindingNavigator.TabIndex = 0;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // employeesBindingNavigatorSaveItem
            // 
            this.employeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesBindingNavigatorSaveItem.Image")));
            this.employeesBindingNavigatorSaveItem.Name = "employeesBindingNavigatorSaveItem";
            this.employeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.employeesBindingNavigatorSaveItem.Text = "Save Data";
            this.employeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeesBindingNavigatorSaveItem_Click);
            // 
            // eMPL_IDLabel
            // 
            eMPL_IDLabel.AutoSize = true;
            eMPL_IDLabel.Location = new System.Drawing.Point(12, 25);
            eMPL_IDLabel.Name = "eMPL_IDLabel";
            eMPL_IDLabel.Size = new System.Drawing.Size(53, 13);
            eMPL_IDLabel.TabIndex = 1;
            eMPL_IDLabel.Text = "EMPL ID:";
            // 
            // eMPL_IDTextBox
            // 
            this.eMPL_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EMPL_ID", true));
            this.eMPL_IDTextBox.Location = new System.Drawing.Point(97, 22);
            this.eMPL_IDTextBox.Name = "eMPL_IDTextBox";
            this.eMPL_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMPL_IDTextBox.TabIndex = 2;
            // 
            // eMPL_FNAMELabel
            // 
            eMPL_FNAMELabel.AutoSize = true;
            eMPL_FNAMELabel.Location = new System.Drawing.Point(12, 49);
            eMPL_FNAMELabel.Name = "eMPL_FNAMELabel";
            eMPL_FNAMELabel.Size = new System.Drawing.Size(79, 13);
            eMPL_FNAMELabel.TabIndex = 3;
            eMPL_FNAMELabel.Text = "EMPL FNAME:";
            // 
            // eMPL_FNAMETextBox
            // 
            this.eMPL_FNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EMPL_FNAME", true));
            this.eMPL_FNAMETextBox.Location = new System.Drawing.Point(97, 42);
            this.eMPL_FNAMETextBox.Name = "eMPL_FNAMETextBox";
            this.eMPL_FNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.eMPL_FNAMETextBox.TabIndex = 4;
            // 
            // eMPL_LNAMELabel
            // 
            eMPL_LNAMELabel.AutoSize = true;
            eMPL_LNAMELabel.Location = new System.Drawing.Point(12, 72);
            eMPL_LNAMELabel.Name = "eMPL_LNAMELabel";
            eMPL_LNAMELabel.Size = new System.Drawing.Size(79, 13);
            eMPL_LNAMELabel.TabIndex = 5;
            eMPL_LNAMELabel.Text = "EMPL LNAME:";
            // 
            // eMPL_LNAMETextBox
            // 
            this.eMPL_LNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EMPL_LNAME", true));
            this.eMPL_LNAMETextBox.Location = new System.Drawing.Point(97, 69);
            this.eMPL_LNAMETextBox.Name = "eMPL_LNAMETextBox";
            this.eMPL_LNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.eMPL_LNAMETextBox.TabIndex = 6;
            // 
            // eMPL_LAST_UPDATELabel
            // 
            eMPL_LAST_UPDATELabel.AutoSize = true;
            eMPL_LAST_UPDATELabel.Location = new System.Drawing.Point(12, 141);
            eMPL_LAST_UPDATELabel.Name = "eMPL_LAST_UPDATELabel";
            eMPL_LAST_UPDATELabel.Size = new System.Drawing.Size(116, 13);
            eMPL_LAST_UPDATELabel.TabIndex = 7;
            eMPL_LAST_UPDATELabel.Text = "EMPL LAST UPDATE:";
            // 
            // eMPL_LAST_UPDATEDateTimePicker
            // 
            this.eMPL_LAST_UPDATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "EMPL_LAST_UPDATE", true));
            this.eMPL_LAST_UPDATEDateTimePicker.Location = new System.Drawing.Point(134, 137);
            this.eMPL_LAST_UPDATEDateTimePicker.Name = "eMPL_LAST_UPDATEDateTimePicker";
            this.eMPL_LAST_UPDATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eMPL_LAST_UPDATEDateTimePicker.TabIndex = 8;
            // 
            // eMPL_CREATE_DATELabel
            // 
            eMPL_CREATE_DATELabel.AutoSize = true;
            eMPL_CREATE_DATELabel.Location = new System.Drawing.Point(12, 171);
            eMPL_CREATE_DATELabel.Name = "eMPL_CREATE_DATELabel";
            eMPL_CREATE_DATELabel.Size = new System.Drawing.Size(117, 13);
            eMPL_CREATE_DATELabel.TabIndex = 9;
            eMPL_CREATE_DATELabel.Text = "EMPL CREATE DATE:";
            // 
            // eMPL_CREATE_DATEDateTimePicker
            // 
            this.eMPL_CREATE_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "EMPL_CREATE_DATE", true));
            this.eMPL_CREATE_DATEDateTimePicker.Location = new System.Drawing.Point(135, 167);
            this.eMPL_CREATE_DATEDateTimePicker.Name = "eMPL_CREATE_DATEDateTimePicker";
            this.eMPL_CREATE_DATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eMPL_CREATE_DATEDateTimePicker.TabIndex = 10;
            // 
            // eMPL_ADDRESSLabel
            // 
            eMPL_ADDRESSLabel.AutoSize = true;
            eMPL_ADDRESSLabel.Location = new System.Drawing.Point(12, 92);
            eMPL_ADDRESSLabel.Name = "eMPL_ADDRESSLabel";
            eMPL_ADDRESSLabel.Size = new System.Drawing.Size(94, 13);
            eMPL_ADDRESSLabel.TabIndex = 11;
            eMPL_ADDRESSLabel.Text = "EMPL ADDRESS:";
            // 
            // eMPL_ADDRESSTextBox
            // 
            this.eMPL_ADDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EMPL_ADDRESS", true));
            this.eMPL_ADDRESSTextBox.Location = new System.Drawing.Point(112, 89);
            this.eMPL_ADDRESSTextBox.Name = "eMPL_ADDRESSTextBox";
            this.eMPL_ADDRESSTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMPL_ADDRESSTextBox.TabIndex = 12;
            // 
            // eMPL_STATELabel
            // 
            eMPL_STATELabel.AutoSize = true;
            eMPL_STATELabel.Location = new System.Drawing.Point(12, 117);
            eMPL_STATELabel.Name = "eMPL_STATELabel";
            eMPL_STATELabel.Size = new System.Drawing.Size(77, 13);
            eMPL_STATELabel.TabIndex = 13;
            eMPL_STATELabel.Text = "EMPL STATE:";
            // 
            // eMPL_STATETextBox
            // 
            this.eMPL_STATETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EMPL_STATE", true));
            this.eMPL_STATETextBox.Location = new System.Drawing.Point(97, 114);
            this.eMPL_STATETextBox.Name = "eMPL_STATETextBox";
            this.eMPL_STATETextBox.Size = new System.Drawing.Size(100, 20);
            this.eMPL_STATETextBox.TabIndex = 14;
            // 
            // eMPLOYEE_JOBSBindingSource
            // 
            this.eMPLOYEE_JOBSBindingSource.DataMember = "EMPLJOB_EMPL_ID_FK";
            this.eMPLOYEE_JOBSBindingSource.DataSource = this.employeesBindingSource;
            // 
            // eMPLOYEE_JOBSTableAdapter
            // 
            this.eMPLOYEE_JOBSTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 447);
            this.Controls.Add(eMPL_STATELabel);
            this.Controls.Add(this.eMPL_STATETextBox);
            this.Controls.Add(eMPL_ADDRESSLabel);
            this.Controls.Add(this.eMPL_ADDRESSTextBox);
            this.Controls.Add(eMPL_CREATE_DATELabel);
            this.Controls.Add(this.eMPL_CREATE_DATEDateTimePicker);
            this.Controls.Add(eMPL_LAST_UPDATELabel);
            this.Controls.Add(this.eMPL_LAST_UPDATEDateTimePicker);
            this.Controls.Add(eMPL_LNAMELabel);
            this.Controls.Add(this.eMPL_LNAMETextBox);
            this.Controls.Add(eMPL_FNAMELabel);
            this.Controls.Add(this.eMPL_FNAMETextBox);
            this.Controls.Add(eMPL_IDLabel);
            this.Controls.Add(this.eMPL_IDTextBox);
            this.Controls.Add(this.employeesBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_JOBSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeesDataSet employeesDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eMPL_IDTextBox;
        private EmployeesDataSetTableAdapters.EMPLOYEE_JOBSTableAdapter eMPLOYEE_JOBSTableAdapter;
        private System.Windows.Forms.TextBox eMPL_FNAMETextBox;
        private System.Windows.Forms.TextBox eMPL_LNAMETextBox;
        private System.Windows.Forms.DateTimePicker eMPL_LAST_UPDATEDateTimePicker;
        private System.Windows.Forms.DateTimePicker eMPL_CREATE_DATEDateTimePicker;
        private System.Windows.Forms.TextBox eMPL_ADDRESSTextBox;
        private System.Windows.Forms.TextBox eMPL_STATETextBox;
        private System.Windows.Forms.BindingSource eMPLOYEE_JOBSBindingSource;
    }
}