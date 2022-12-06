namespace Hospital_Management_System
{
    partial class Nurse
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
            this.panelGender = new System.Windows.Forms.Panel();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.PatientDataGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marretialStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedPatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_DBDataSet6 = new Hospital_Management_System.Hospital_DBDataSet6();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchTextBpx = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.OperationPanel2 = new System.Windows.Forms.Panel();
            this.UpdatBtn = new System.Windows.Forms.Button();
            this.cbxBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblBG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.comboNurse = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_DBDataSet = new Hospital_Management_System.Hospital_DBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMarried = new System.Windows.Forms.Panel();
            this.rbtnUnmarried = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseTableAdapter = new Hospital_Management_System.Hospital_DBDataSet6TableAdapters.NurseTableAdapter();
            this.patientTableAdapter = new Hospital_Management_System.Hospital_DBDataSetTableAdapters.PatientTableAdapter();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet6)).BeginInit();
            this.OperationPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet)).BeginInit();
            this.panelMarried.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.rbtnFemale);
            this.panelGender.Controls.Add(this.lblGender);
            this.panelGender.Controls.Add(this.rbtnMale);
            this.panelGender.Location = new System.Drawing.Point(18, 265);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(471, 51);
            this.panelGender.TabIndex = 47;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(299, 19);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(85, 24);
            this.rbtnFemale.TabIndex = 15;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(66, 19);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(165, 19);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(66, 24);
            this.rbtnMale.TabIndex = 14;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ArrivalDate.Location = new System.Drawing.Point(181, 423);
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Size = new System.Drawing.Size(139, 27);
            this.ArrivalDate.TabIndex = 44;
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(52, 423);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(81, 20);
            this.lblArrivalDate.TabIndex = 43;
            this.lblArrivalDate.Text = "Join Date";
            // 
            // BirthDate
            // 
            this.BirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate.Location = new System.Drawing.Point(181, 374);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(137, 27);
            this.BirthDate.TabIndex = 40;
            // 
            // PatientDataGV
            // 
            this.PatientDataGV.AllowUserToAddRows = false;
            this.PatientDataGV.AllowUserToDeleteRows = false;
            this.PatientDataGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientDataGV.AutoGenerateColumns = false;
            this.PatientDataGV.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.PatientDataGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.marretialStatusDataGridViewTextBoxColumn,
            this.assignedPatientDataGridViewTextBoxColumn,
            this.joindateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.PatientDataGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PatientDataGV.DataSource = this.nurseBindingSource;
            this.PatientDataGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PatientDataGV.Location = new System.Drawing.Point(3, 77);
            this.PatientDataGV.Name = "PatientDataGV";
            this.PatientDataGV.ReadOnly = true;
            this.PatientDataGV.RowHeadersWidth = 51;
            this.PatientDataGV.RowTemplate.Height = 24;
            this.PatientDataGV.Size = new System.Drawing.Size(1361, 965);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloodGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            this.dateofbirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateofbirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // marretialStatusDataGridViewTextBoxColumn
            // 
            this.marretialStatusDataGridViewTextBoxColumn.DataPropertyName = "Marretial_Status";
            this.marretialStatusDataGridViewTextBoxColumn.HeaderText = "Marretial_Status";
            this.marretialStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marretialStatusDataGridViewTextBoxColumn.Name = "marretialStatusDataGridViewTextBoxColumn";
            this.marretialStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.marretialStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignedPatientDataGridViewTextBoxColumn
            // 
            this.assignedPatientDataGridViewTextBoxColumn.DataPropertyName = "Assigned_Patient";
            this.assignedPatientDataGridViewTextBoxColumn.HeaderText = "Assigned_Patient";
            this.assignedPatientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignedPatientDataGridViewTextBoxColumn.Name = "assignedPatientDataGridViewTextBoxColumn";
            this.assignedPatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.assignedPatientDataGridViewTextBoxColumn.Width = 125;
            // 
            // joindateDataGridViewTextBoxColumn
            // 
            this.joindateDataGridViewTextBoxColumn.DataPropertyName = "Join_date";
            this.joindateDataGridViewTextBoxColumn.HeaderText = "Join_date";
            this.joindateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.joindateDataGridViewTextBoxColumn.Name = "joindateDataGridViewTextBoxColumn";
            this.joindateDataGridViewTextBoxColumn.ReadOnly = true;
            this.joindateDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataMember = "Nurse";
            this.nurseBindingSource.DataSource = this.hospital_DBDataSet6;
            // 
            // hospital_DBDataSet6
            // 
            this.hospital_DBDataSet6.DataSetName = "Hospital_DBDataSet6";
            this.hospital_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(299, 16);
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
            this.SearchTextBpx.Location = new System.Drawing.Point(976, 21);
            this.SearchTextBpx.Name = "SearchTextBpx";
            this.SearchTextBpx.Size = new System.Drawing.Size(362, 32);
            this.SearchTextBpx.TabIndex = 56;
            this.SearchTextBpx.Text = "Search By Name";
            this.SearchTextBpx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBpx.Click += new System.EventHandler(this.SearchTextBpx_Click_1);
            this.SearchTextBpx.TextChanged += new System.EventHandler(this.SearchTextBpx_TextChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(69, 16);
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
            this.SearchBtn.Location = new System.Drawing.Point(870, 19);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 36);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
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
            this.OperationPanel2.Size = new System.Drawing.Size(1361, 67);
            this.OperationPanel2.TabIndex = 3;
            // 
            // UpdatBtn
            // 
            this.UpdatBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatBtn.Location = new System.Drawing.Point(30, 623);
            this.UpdatBtn.Name = "UpdatBtn";
            this.UpdatBtn.Size = new System.Drawing.Size(211, 43);
            this.UpdatBtn.TabIndex = 62;
            this.UpdatBtn.Text = "Update Info";
            this.UpdatBtn.UseVisualStyleBackColor = false;
            this.UpdatBtn.Click += new System.EventHandler(this.UpdatBtn_Click);
            // 
            // cbxBloodGroup
            // 
            this.cbxBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBloodGroup.FormattingEnabled = true;
            this.cbxBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.cbxBloodGroup.Location = new System.Drawing.Point(181, 331);
            this.cbxBloodGroup.Name = "cbxBloodGroup";
            this.cbxBloodGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxBloodGroup.Size = new System.Drawing.Size(137, 28);
            this.cbxBloodGroup.TabIndex = 61;
            this.cbxBloodGroup.Text = "Select";
            // 
            // lblBG
            // 
            this.lblBG.AutoSize = true;
            this.lblBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBG.Location = new System.Drawing.Point(45, 331);
            this.lblBG.Name = "lblBG";
            this.lblBG.Size = new System.Drawing.Size(103, 20);
            this.lblBG.TabIndex = 60;
            this.lblBG.Text = "Blood Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 36);
            this.label4.TabIndex = 55;
            this.label4.Text = "Manage Nurse";
            
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientBtn.Location = new System.Drawing.Point(264, 623);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(221, 43);
            this.AddPatientBtn.TabIndex = 38;
            this.AddPatientBtn.Text = "Add Info";
            this.AddPatientBtn.UseVisualStyleBackColor = false;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // comboNurse
            // 
            this.comboNurse.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Name", true));
            this.comboNurse.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.patientBindingSource, "Name", true));
            this.comboNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNurse.FormattingEnabled = true;
            this.comboNurse.Location = new System.Drawing.Point(179, 559);
            this.comboNurse.Name = "comboNurse";
            this.comboNurse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboNurse.Size = new System.Drawing.Size(312, 28);
            this.comboNurse.TabIndex = 52;
            this.comboNurse.Text = "Select";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Assigned Patient";
            // 
            // panelMarried
            // 
            this.panelMarried.Controls.Add(this.rbtnUnmarried);
            this.panelMarried.Controls.Add(this.label1);
            this.panelMarried.Controls.Add(this.rbtnMarried);
            this.panelMarried.Location = new System.Drawing.Point(10, 466);
            this.panelMarried.Name = "panelMarried";
            this.panelMarried.Size = new System.Drawing.Size(479, 51);
            this.panelMarried.TabIndex = 48;
            // 
            // rbtnUnmarried
            // 
            this.rbtnUnmarried.AutoSize = true;
            this.rbtnUnmarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUnmarried.Location = new System.Drawing.Point(299, 19);
            this.rbtnUnmarried.Name = "rbtnUnmarried";
            this.rbtnUnmarried.Size = new System.Drawing.Size(108, 24);
            this.rbtnUnmarried.TabIndex = 15;
            this.rbtnUnmarried.TabStop = true;
            this.rbtnUnmarried.Text = "Unmarried";
            this.rbtnUnmarried.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marretial Status";
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMarried.Location = new System.Drawing.Point(165, 19);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(87, 24);
            this.rbtnMarried.TabIndex = 14;
            this.rbtnMarried.TabStop = true;
            this.rbtnMarried.Text = "Married";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(62, 371);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(86, 20);
            this.lblBirthDate.TabIndex = 39;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.UpdatBtn);
            this.panel1.Controls.Add(this.cbxBloodGroup);
            this.panel1.Controls.Add(this.lblBG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddPatientBtn);
            this.panel1.Controls.Add(this.comboNurse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panelMarried);
            this.panel1.Controls.Add(this.panelGender);
            this.panel1.Controls.Add(this.ArrivalDate);
            this.panel1.Controls.Add(this.lblArrivalDate);
            this.panel1.Controls.Add(this.BirthDate);
            this.panel1.Controls.Add(this.lblBirthDate);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 1063);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(175, 144);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 27);
            this.txtAddress.TabIndex = 37;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(77, 147);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(177, 185);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(310, 27);
            this.txtPhone.TabIndex = 35;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(92, 188);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 20);
            this.lblPhone.TabIndex = 34;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(175, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 27);
            this.txtEmail.TabIndex = 33;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(97, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(175, 95);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(310, 27);
            this.tbxName.TabIndex = 31;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(82, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1362, 1063);
            this.tableLayoutPanel2.TabIndex = 2;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1889, 1069);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // BloodGroup
            // 
            this.BloodGroup.DataPropertyName = "BloodGroup";
            this.BloodGroup.HeaderText = "BloodGroup";
            this.BloodGroup.MinimumWidth = 6;
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.Width = 125;
            // 
            // nurseTableAdapter
            // 
            this.nurseTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
           
            this.Size = new System.Drawing.Size(1889, 1069);
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet6)).EndInit();
            this.OperationPanel2.ResumeLayout(false);
            this.OperationPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet)).EndInit();
            this.panelMarried.ResumeLayout(false);
            this.panelMarried.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.DateTimePicker ArrivalDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.DataGridView PatientDataGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SearchTextBpx;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Panel OperationPanel2;
        private System.Windows.Forms.Button UpdatBtn;
        private System.Windows.Forms.ComboBox cbxBloodGroup;
        private System.Windows.Forms.Label lblBG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPatientBtn;
        private System.Windows.Forms.ComboBox comboNurse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMarried;
        private System.Windows.Forms.RadioButton rbtnUnmarried;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marretialStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private Hospital_DBDataSet6 hospital_DBDataSet6;
        private Hospital_DBDataSet6TableAdapters.NurseTableAdapter nurseTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Hospital_DBDataSet hospital_DBDataSet;
        private Hospital_DBDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
    }
}
