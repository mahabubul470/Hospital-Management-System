namespace Hospital_Management_System
{
    partial class Doctor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.JoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSpeciality = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_DBDataSet = new Hospital_Management_System.Hospital_DBDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdatBtn = new System.Windows.Forms.Button();
            this.cbxBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblBG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.panelMarried = new System.Windows.Forms.Panel();
            this.rbtnUnmarried = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.panelGender = new System.Windows.Forms.Panel();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OperationPanel2 = new System.Windows.Forms.Panel();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchTextBpx = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.PatientDataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDBDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_DBDataSet7 = new Hospital_Management_System.Hospital_DBDataSet7();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new Hospital_Management_System.Hospital_DBDataSet7TableAdapters.DoctorTableAdapter();
            this.patientTableAdapter = new Hospital_Management_System.Hospital_DBDataSetTableAdapters.PatientTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet)).BeginInit();
            this.panelMarried.SuspendLayout();
            this.panelGender.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.OperationPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.JoiningDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbxDesignation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxSpeciality);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbPatient);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UpdatBtn);
            this.panel1.Controls.Add(this.cbxBloodGroup);
            this.panel1.Controls.Add(this.lblBG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddPatientBtn);
            this.panel1.Controls.Add(this.panelMarried);
            this.panel1.Controls.Add(this.panelGender);
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
            this.panel1.Size = new System.Drawing.Size(515, 1044);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // JoiningDate
            // 
            this.JoiningDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JoiningDate.Location = new System.Drawing.Point(168, 534);
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.Size = new System.Drawing.Size(137, 27);
            this.JoiningDate.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Joining Date";
            // 
            // tbxDesignation
            // 
            this.tbxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesignation.Location = new System.Drawing.Point(166, 270);
            this.tbxDesignation.Name = "tbxDesignation";
            this.tbxDesignation.Size = new System.Drawing.Size(310, 27);
            this.tbxDesignation.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Designation";
            // 
            // tbxSpeciality
            // 
            this.tbxSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSpeciality.Location = new System.Drawing.Point(166, 313);
            this.tbxSpeciality.Name = "tbxSpeciality";
            this.tbxSpeciality.Size = new System.Drawing.Size(310, 27);
            this.tbxSpeciality.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Speciality";
            // 
            // cmbPatient
            // 
            this.cmbPatient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.patientBindingSource, "Name", true));
            this.cmbPatient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Name", true));
            this.cmbPatient.DataSource = this.patientBindingSource;
            this.cmbPatient.DisplayMember = "Name";
            this.cmbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(180, 651);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPatient.Size = new System.Drawing.Size(312, 28);
            this.cmbPatient.TabIndex = 64;
            this.cmbPatient.ValueMember = "Name";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Assigne Patient";
            // 
            // UpdatBtn
            // 
            this.UpdatBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdatBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.UpdatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.UpdatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatBtn.Location = new System.Drawing.Point(29, 734);
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
            this.cbxBloodGroup.Location = new System.Drawing.Point(170, 440);
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
            this.lblBG.Location = new System.Drawing.Point(36, 440);
            this.lblBG.Name = "lblBG";
            this.lblBG.Size = new System.Drawing.Size(103, 20);
            this.lblBG.TabIndex = 60;
            this.lblBG.Text = "Blood Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 36);
            this.label4.TabIndex = 55;
            this.label4.Text = "Manage Doctors";
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddPatientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddPatientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.AddPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientBtn.Location = new System.Drawing.Point(263, 734);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(221, 43);
            this.AddPatientBtn.TabIndex = 38;
            this.AddPatientBtn.Text = "Add Info";
            this.AddPatientBtn.UseVisualStyleBackColor = false;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // panelMarried
            // 
            this.panelMarried.Controls.Add(this.rbtnUnmarried);
            this.panelMarried.Controls.Add(this.label1);
            this.panelMarried.Controls.Add(this.rbtnMarried);
            this.panelMarried.Location = new System.Drawing.Point(27, 578);
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
            // panelGender
            // 
            this.panelGender.Controls.Add(this.rbtnFemale);
            this.panelGender.Controls.Add(this.lblGender);
            this.panelGender.Controls.Add(this.rbtnMale);
            this.panelGender.Location = new System.Drawing.Point(13, 370);
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
            // BirthDate
            // 
            this.BirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate.Location = new System.Drawing.Point(170, 490);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(137, 27);
            this.BirthDate.TabIndex = 40;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(51, 487);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(86, 20);
            this.lblBirthDate.TabIndex = 39;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(168, 140);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 27);
            this.txtAddress.TabIndex = 37;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(68, 140);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(170, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(310, 27);
            this.txtPhone.TabIndex = 35;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(83, 184);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 20);
            this.lblPhone.TabIndex = 34;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(168, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 27);
            this.txtEmail.TabIndex = 33;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(96, 227);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(168, 92);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(310, 27);
            this.tbxName.TabIndex = 31;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(86, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1888, 1050);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1361, 1044);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // OperationPanel2
            // 
            this.OperationPanel2.BackColor = System.Drawing.Color.White;
            this.OperationPanel2.Controls.Add(this.ViewAllBtn);
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
            // ViewAllBtn
            // 
            this.ViewAllBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllBtn.Location = new System.Drawing.Point(560, 16);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(212, 37);
            this.ViewAllBtn.TabIndex = 58;
            this.ViewAllBtn.Text = "View All Information";
            this.ViewAllBtn.UseVisualStyleBackColor = false;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.ID,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.PatientDataGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PatientDataGV.DataSource = this.doctorBindingSource1;
            this.PatientDataGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PatientDataGV.Location = new System.Drawing.Point(3, 76);
            this.PatientDataGV.Name = "PatientDataGV";
            this.PatientDataGV.ReadOnly = true;
            this.PatientDataGV.RowHeadersWidth = 51;
            this.PatientDataGV.RowTemplate.Height = 24;
            this.PatientDataGV.Size = new System.Drawing.Size(1361, 965);
            this.PatientDataGV.TabIndex = 4;
            this.PatientDataGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientDataGV_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Doctor_Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
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
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "Blood_Group";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood Group";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloodGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Speciality";
            this.specialityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.hospitalDBDataSet7BindingSource;
            // 
            // hospitalDBDataSet7BindingSource
            // 
            this.hospitalDBDataSet7BindingSource.DataSource = this.hospital_DBDataSet7;
            this.hospitalDBDataSet7BindingSource.Position = 0;
            // 
            // hospital_DBDataSet7
            // 
            this.hospital_DBDataSet7.DataSetName = "Hospital_DBDataSet7";
            this.hospital_DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospitalDBDataSet7BindingSource;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Doctor";
            this.Size = new System.Drawing.Size(1888, 1050);
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet)).EndInit();
            this.panelMarried.ResumeLayout(false);
            this.panelMarried.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.OperationPanel2.ResumeLayout(false);
            this.OperationPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPatientBtn;
        private System.Windows.Forms.Panel panelMarried;
        private System.Windows.Forms.RadioButton rbtnUnmarried;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel OperationPanel2;
        private System.Windows.Forms.TextBox SearchTextBpx;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView PatientDataGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.ComboBox cbxBloodGroup;
        private System.Windows.Forms.Label lblBG;
        private System.Windows.Forms.Button UpdatBtn;
        private System.Windows.Forms.TextBox tbxDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSpeciality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker JoiningDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource hospitalDBDataSet7BindingSource;
        private Hospital_DBDataSet7 hospital_DBDataSet7;
        private Hospital_DBDataSet7TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Hospital_DBDataSet hospital_DBDataSet;
        private Hospital_DBDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedPatiendDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
    }
}
