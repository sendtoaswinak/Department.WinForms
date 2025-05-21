namespace Department.WinForms
{
    partial class FrmDepartment
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
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtDeptNameVal = new System.Windows.Forms.TextBox();
            this.chkIsActiveVal = new System.Windows.Forms.CheckBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblDeptIdVal = new System.Windows.Forms.Label();
            this.lblDeptId = new System.Windows.Forms.Label();
            this.grdDisplay = new System.Windows.Forms.DataGridView();
            this.departmentDbDataSet = new Department.WinForms.DepartmentDbDataSet();
            this.tblDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepartmentsTableAdapter = new Department.WinForms.DepartmentDbDataSetTableAdapters.tblDepartmentsTableAdapter();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnExit);
            this.grpDetails.Controls.Add(this.btnClear);
            this.grpDetails.Controls.Add(this.btnDelete);
            this.grpDetails.Controls.Add(this.btnUpdate);
            this.grpDetails.Controls.Add(this.btnInsert);
            this.grpDetails.Controls.Add(this.txtDeptNameVal);
            this.grpDetails.Controls.Add(this.chkIsActiveVal);
            this.grpDetails.Controls.Add(this.lblIsActive);
            this.grpDetails.Controls.Add(this.lblDeptName);
            this.grpDetails.Controls.Add(this.lblDeptIdVal);
            this.grpDetails.Controls.Add(this.lblDeptId);
            this.grpDetails.Location = new System.Drawing.Point(7, 16);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(301, 404);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Fill the Details";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(100, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(195, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(10, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(195, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.Location = new System.Drawing.Point(10, 173);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 30);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // txtDeptNameVal
            // 
            this.txtDeptNameVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeptNameVal.Location = new System.Drawing.Point(170, 86);
            this.txtDeptNameVal.Name = "txtDeptNameVal";
            this.txtDeptNameVal.Size = new System.Drawing.Size(100, 19);
            this.txtDeptNameVal.TabIndex = 5;
            // 
            // chkIsActiveVal
            // 
            this.chkIsActiveVal.AutoSize = true;
            this.chkIsActiveVal.Location = new System.Drawing.Point(170, 131);
            this.chkIsActiveVal.Name = "chkIsActiveVal";
            this.chkIsActiveVal.Size = new System.Drawing.Size(22, 21);
            this.chkIsActiveVal.TabIndex = 4;
            this.chkIsActiveVal.UseVisualStyleBackColor = true;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(6, 130);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(65, 20);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "IsActive";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(6, 86);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(140, 20);
            this.lblDeptName.TabIndex = 2;
            this.lblDeptName.Text = "Department Name";
            // 
            // lblDeptIdVal
            // 
            this.lblDeptIdVal.AutoSize = true;
            this.lblDeptIdVal.Location = new System.Drawing.Point(166, 40);
            this.lblDeptIdVal.Name = "lblDeptIdVal";
            this.lblDeptIdVal.Size = new System.Drawing.Size(18, 20);
            this.lblDeptIdVal.TabIndex = 1;
            this.lblDeptIdVal.Text = "0";
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(6, 40);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(112, 20);
            this.lblDeptId.TabIndex = 0;
            this.lblDeptId.Text = "Department Id";
            // 
            // grdDisplay
            // 
            this.grdDisplay.AllowUserToAddRows = false;
            this.grdDisplay.AllowUserToDeleteRows = false;
            this.grdDisplay.AllowUserToResizeColumns = false;
            this.grdDisplay.AllowUserToResizeRows = false;
            this.grdDisplay.AutoGenerateColumns = false;
            this.grdDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.grdDisplay.DataSource = this.tblDepartmentsBindingSource;
            this.grdDisplay.Location = new System.Drawing.Point(314, 22);
            this.grdDisplay.MultiSelect = false;
            this.grdDisplay.Name = "grdDisplay";
            this.grdDisplay.ReadOnly = true;
            this.grdDisplay.RowHeadersWidth = 62;
            this.grdDisplay.RowTemplate.Height = 28;
            this.grdDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDisplay.Size = new System.Drawing.Size(474, 398);
            this.grdDisplay.TabIndex = 1;
            this.grdDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDisplay_CellClick);
            // 
            // departmentDbDataSet
            // 
            this.departmentDbDataSet.DataSetName = "DepartmentDbDataSet";
            this.departmentDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartmentsBindingSource
            // 
            this.tblDepartmentsBindingSource.DataMember = "tblDepartments";
            this.tblDepartmentsBindingSource.DataSource = this.departmentDbDataSet;
            // 
            // tblDepartmentsTableAdapter
            // 
            this.tblDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.ReadOnly = true;
            this.snoDataGridViewTextBoxColumn.Width = 74;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 87;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 71;
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdDisplay);
            this.Controls.Add(this.grpDetails);
            this.Name = "FrmDepartment";
            this.Text = "Department";
            //this.Load += new System.EventHandler(this.FrmDepartment_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.DataGridView grdDisplay;
        private DepartmentDbDataSet departmentDbDataSet;
        private System.Windows.Forms.BindingSource tblDepartmentsBindingSource;
        private DepartmentDbDataSetTableAdapters.tblDepartmentsTableAdapter tblDepartmentsTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtDeptNameVal;
        private System.Windows.Forms.CheckBox chkIsActiveVal;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblDeptIdVal;
        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}

