namespace Hospital_Management_System
{
    partial class Medicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OperationPanel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchTextBpx = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtMCode = new System.Windows.Forms.TextBox();
            this.lblGuardian = new System.Windows.Forms.Label();
            this.PatientDataGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineDataSet = new Hospital_Management_System.MedicineDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_DBDataSet = new Hospital_Management_System.Hospital_DBDataSet();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.patientTableAdapter = new Hospital_Management_System.Hospital_DBDataSetTableAdapters.PatientTableAdapter();
            this.UpdatBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.ExpireDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.txtMCategory = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxMName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.medicineTableAdapter = new Hospital_Management_System.MedicineDataSetTableAdapters.MedicineTableAdapter();
            this.OperationPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationPanel2
            // 
            this.OperationPanel2.BackColor = System.Drawing.Color.White;
            this.OperationPanel2.Controls.Add(this.button2);
            this.OperationPanel2.Controls.Add(this.SearchTextBpx);
            this.OperationPanel2.Controls.Add(this.RefreshBtn);
            this.OperationPanel2.Controls.Add(this.SearchBtn);
            this.OperationPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.OperationPanel2.Location = new System.Drawing.Point(3, 3);
            this.OperationPanel2.Name = "OperationPanel2";
            this.OperationPanel2.Size = new System.Drawing.Size(1382, 45);
            this.OperationPanel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(369, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 57;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchTextBpx
            // 
            this.SearchTextBpx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBpx.Location = new System.Drawing.Point(1004, 7);
            this.SearchTextBpx.Name = "SearchTextBpx";
            this.SearchTextBpx.Size = new System.Drawing.Size(362, 32);
            this.SearchTextBpx.TabIndex = 56;
            this.SearchTextBpx.Text = "Search By Name";
            this.SearchTextBpx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBpx.Click += new System.EventHandler(this.SearchTextBpx_Click_1);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(77, 5);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(132, 37);
            this.RefreshBtn.TabIndex = 31;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(898, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 36);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // txtMCode
            // 
            this.txtMCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCode.Location = new System.Drawing.Point(175, 101);
            this.txtMCode.Name = "txtMCode";
            this.txtMCode.Size = new System.Drawing.Size(310, 27);
            this.txtMCode.TabIndex = 46;
            // 
            // lblGuardian
            // 
            this.lblGuardian.AutoSize = true;
            this.lblGuardian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardian.Location = new System.Drawing.Point(28, 104);
            this.lblGuardian.Name = "lblGuardian";
            this.lblGuardian.Size = new System.Drawing.Size(116, 20);
            this.lblGuardian.TabIndex = 45;
            this.lblGuardian.Text = "Medicine Cost";
            // 
            // PatientDataGV
            // 
            this.PatientDataGV.AllowUserToAddRows = false;
            this.PatientDataGV.AllowUserToDeleteRows = false;
            this.PatientDataGV.AutoGenerateColumns = false;
            this.PatientDataGV.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.PatientDataGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.medicineNameDataGridViewTextBoxColumn,
            this.medicineCodeDataGridViewTextBoxColumn,
            this.medicineCategoryDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.companyPhoneDataGridViewTextBoxColumn,
            this.companyEmailDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn});
            this.PatientDataGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PatientDataGV.DataSource = this.medicineBindingSource;
            this.PatientDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientDataGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PatientDataGV.Location = new System.Drawing.Point(3, 54);
            this.PatientDataGV.Name = "PatientDataGV";
            this.PatientDataGV.ReadOnly = true;
            this.PatientDataGV.RowHeadersWidth = 51;
            this.PatientDataGV.RowTemplate.Height = 24;
            this.PatientDataGV.Size = new System.Drawing.Size(1382, 676);
            this.PatientDataGV.TabIndex = 4;
            this.PatientDataGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientDataGV_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "Medicine_Name";
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.medicineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            this.medicineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicineCodeDataGridViewTextBoxColumn
            // 
            this.medicineCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.medicineCodeDataGridViewTextBoxColumn.DataPropertyName = "Medicine_Code";
            this.medicineCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.medicineCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineCodeDataGridViewTextBoxColumn.Name = "medicineCodeDataGridViewTextBoxColumn";
            this.medicineCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicineCodeDataGridViewTextBoxColumn.Width = 70;
            // 
            // medicineCategoryDataGridViewTextBoxColumn
            // 
            this.medicineCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.medicineCategoryDataGridViewTextBoxColumn.DataPropertyName = "Medicine_Category";
            this.medicineCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.medicineCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineCategoryDataGridViewTextBoxColumn.Name = "medicineCategoryDataGridViewTextBoxColumn";
            this.medicineCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicineCategoryDataGridViewTextBoxColumn.Width = 94;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "Company_Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.companyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyPhoneDataGridViewTextBoxColumn
            // 
            this.companyPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyPhoneDataGridViewTextBoxColumn.DataPropertyName = "Company_Phone";
            this.companyPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.companyPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyPhoneDataGridViewTextBoxColumn.Name = "companyPhoneDataGridViewTextBoxColumn";
            this.companyPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyEmailDataGridViewTextBoxColumn
            // 
            this.companyEmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.companyEmailDataGridViewTextBoxColumn.DataPropertyName = "Company_Email";
            this.companyEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.companyEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyEmailDataGridViewTextBoxColumn.Name = "companyEmailDataGridViewTextBoxColumn";
            this.companyEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyEmailDataGridViewTextBoxColumn.Width = 71;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "Arrival_Date";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.arrivalDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalDateDataGridViewTextBoxColumn.Width = 67;
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            this.expireDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expireDateDataGridViewTextBoxColumn.Width = 106;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            this.medicineBindingSource.DataSource = this.medicineDataSet;
            // 
            // medicineDataSet
            // 
            this.medicineDataSet.DataSetName = "MedicineDataSet";
            this.medicineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospital_DBDataSet;
            // 
            // hospital_DBDataSet
            // 
            this.hospital_DBDataSet.DataSetName = "Hospital_DBDataSet";
            this.hospital_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.OperationPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PatientDataGV, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(524, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992337F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.00766F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1388, 733);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // UpdatBtn
            // 
            this.UpdatBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatBtn.Location = new System.Drawing.Point(30, 439);
            this.UpdatBtn.Name = "UpdatBtn";
            this.UpdatBtn.Size = new System.Drawing.Size(211, 43);
            this.UpdatBtn.TabIndex = 62;
            this.UpdatBtn.Text = "Update Info";
            this.UpdatBtn.UseVisualStyleBackColor = false;
            this.UpdatBtn.Click += new System.EventHandler(this.UpdatBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 36);
            this.label4.TabIndex = 55;
            this.label4.Text = "Medicine Info";
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientBtn.Location = new System.Drawing.Point(264, 439);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(221, 43);
            this.AddPatientBtn.TabIndex = 38;
            this.AddPatientBtn.Text = "Add Info";
            this.AddPatientBtn.UseVisualStyleBackColor = false;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtCPhone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.ExpireDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ArrivalDate);
            this.panel1.Controls.Add(this.lblArrivalDate);
            this.panel1.Controls.Add(this.UpdatBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddPatientBtn);
            this.panel1.Controls.Add(this.txtMCode);
            this.panel1.Controls.Add(this.lblGuardian);
            this.panel1.Controls.Add(this.txtMCategory);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtCName);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.tbxMName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 733);
            this.panel1.TabIndex = 1;
            // 
            // txtCPhone
            // 
            this.txtCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPhone.Location = new System.Drawing.Point(175, 235);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(310, 27);
            this.txtCPhone.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Company Phone";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEmail.Location = new System.Drawing.Point(173, 279);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(310, 27);
            this.txtCEmail.TabIndex = 68;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(31, 286);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 20);
            this.lblEmail.TabIndex = 67;
            this.lblEmail.Text = "Company Email";
            // 
            // ExpireDate
            // 
            this.ExpireDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpireDate.Location = new System.Drawing.Point(191, 374);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Size = new System.Drawing.Size(137, 27);
            this.ExpireDate.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Expire Date";
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ArrivalDate.Location = new System.Drawing.Point(188, 333);
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Size = new System.Drawing.Size(139, 27);
            this.ArrivalDate.TabIndex = 64;
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(59, 333);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(98, 20);
            this.lblArrivalDate.TabIndex = 63;
            this.lblArrivalDate.Text = "Arrival Date";
            // 
            // txtMCategory
            // 
            this.txtMCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCategory.Location = new System.Drawing.Point(175, 144);
            this.txtMCategory.Name = "txtMCategory";
            this.txtMCategory.Size = new System.Drawing.Size(310, 27);
            this.txtMCategory.TabIndex = 37;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(5, 144);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(148, 20);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Medicine Category";
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(177, 185);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(310, 27);
            this.txtCName.TabIndex = 35;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(28, 185);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 20);
            this.lblPhone.TabIndex = 34;
            this.lblPhone.Text = "Company Name";
            // 
            // tbxMName
            // 
            this.tbxMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMName.Location = new System.Drawing.Point(175, 60);
            this.tbxMName.Name = "tbxMName";
            this.tbxMName.Size = new System.Drawing.Size(310, 27);
            this.tbxMName.TabIndex = 31;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(28, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 20);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Medicine Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1915, 739);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Medicine";
            this.Size = new System.Drawing.Size(1915, 739);
            this.Load += new System.EventHandler(this.Medicine_Load);
            this.OperationPanel2.ResumeLayout(false);
            this.OperationPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OperationPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SearchTextBpx;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtMCode;
        private System.Windows.Forms.Label lblGuardian;
        private System.Windows.Forms.DataGridView PatientDataGV;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Hospital_DBDataSet hospital_DBDataSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Hospital_DBDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Button UpdatBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPatientBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMCategory;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbxMName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker ArrivalDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.DateTimePicker ExpireDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private MedicineDataSet medicineDataSet;
        private MedicineDataSetTableAdapters.MedicineTableAdapter medicineTableAdapter;
    }
}
