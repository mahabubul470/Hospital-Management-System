namespace Hospital_Management_System
{
    partial class AdminForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenue = new System.Windows.Forms.Panel();
            this.BtnMedicine = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.BtnNurse = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblWlcome = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1687F));
            this.tableLayoutPanel1.Controls.Add(this.panelMenue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Container, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1848, 1055);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelMenue
            // 
            this.panelMenue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelMenue.Controls.Add(this.pictureBox6);
            this.panelMenue.Controls.Add(this.BtnMedicine);
            this.panelMenue.Controls.Add(this.BtnLogOut);
            this.panelMenue.Controls.Add(this.pictureBox5);
            this.panelMenue.Controls.Add(this.pictureBox4);
            this.panelMenue.Controls.Add(this.pictureBox3);
            this.panelMenue.Controls.Add(this.pictureBox2);
            this.panelMenue.Controls.Add(this.pictureBox1);
            this.panelMenue.Controls.Add(this.UserBtn);
            this.panelMenue.Controls.Add(this.lblAdminName);
            this.panelMenue.Controls.Add(this.BtnPatient);
            this.panelMenue.Controls.Add(this.BtnDoctor);
            this.panelMenue.Controls.Add(this.BtnNurse);
            this.panelMenue.Controls.Add(this.btnHome);
            this.panelMenue.Controls.Add(this.lblWlcome);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenue.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.panelMenue.Location = new System.Drawing.Point(3, 3);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(155, 1049);
            this.panelMenue.TabIndex = 2;
            // 
            // BtnMedicine
            // 
            this.BtnMedicine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedicine.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnMedicine.Location = new System.Drawing.Point(0, 685);
            this.BtnMedicine.Name = "BtnMedicine";
            this.BtnMedicine.Size = new System.Drawing.Size(152, 84);
            this.BtnMedicine.TabIndex = 17;
            this.BtnMedicine.Text = "Medicine";
            this.BtnMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMedicine.UseVisualStyleBackColor = false;
            this.BtnMedicine.Click += new System.EventHandler(this.BtnMedicine_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(3, 898);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(152, 79);
            this.BtnLogOut.TabIndex = 16;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.Location = new System.Drawing.Point(-3, 538);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(158, 101);
            this.UserBtn.TabIndex = 8;
            this.UserBtn.Text = "User";
            this.UserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserBtn.UseVisualStyleBackColor = false;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(20, 32);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(56, 20);
            this.lblAdminName.TabIndex = 7;
            this.lblAdminName.Text = "Admin";
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatient.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnPatient.Location = new System.Drawing.Point(-3, 180);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(158, 96);
            this.BtnPatient.TabIndex = 6;
            this.BtnPatient.Text = "Patient";
            this.BtnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPatient.UseVisualStyleBackColor = false;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoctor.Location = new System.Drawing.Point(-3, 290);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(158, 100);
            this.BtnDoctor.TabIndex = 5;
            this.BtnDoctor.Text = "Doctor";
            this.BtnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDoctor.UseVisualStyleBackColor = false;
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // BtnNurse
            // 
            this.BtnNurse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNurse.Location = new System.Drawing.Point(-3, 411);
            this.BtnNurse.Name = "BtnNurse";
            this.BtnNurse.Size = new System.Drawing.Size(158, 101);
            this.BtnNurse.TabIndex = 4;
            this.BtnNurse.Text = "Nurse";
            this.BtnNurse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNurse.UseVisualStyleBackColor = false;
            this.BtnNurse.Click += new System.EventHandler(this.BtnNurse_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.Location = new System.Drawing.Point(-3, 72);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(158, 93);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblWlcome
            // 
            this.lblWlcome.AutoSize = true;
            this.lblWlcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlcome.Location = new System.Drawing.Point(20, 6);
            this.lblWlcome.Name = "lblWlcome";
            this.lblWlcome.Size = new System.Drawing.Size(83, 20);
            this.lblWlcome.TabIndex = 1;
            this.lblWlcome.Text = "Welcome,";
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.SystemColors.Control;
            this.Container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(164, 3);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1681, 1049);
            this.Container.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Hospital_Management_System.Properties.Resources.medicine;
            this.pictureBox6.Location = new System.Drawing.Point(9, 701);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 49);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.BtnMedicine_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Hospital_Management_System.Properties.Resources._113_1132993_hospital_hospital_icon_transparent;
            this.pictureBox5.Location = new System.Drawing.Point(9, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hospital_Management_System.Properties.Resources.nursing_reminder_icons_download_free_png_and_vector_icons_on_pngtree_nurse_icon_png_512_512;
            this.pictureBox4.Location = new System.Drawing.Point(9, 436);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.BtnNurse_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hospital_Management_System.Properties.Resources._203_2036943_svg_png_icon_my_doctor_icon_png;
            this.pictureBox3.Location = new System.Drawing.Point(9, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hospital_Management_System.Properties.Resources.images__1_;
            this.pictureBox2.Location = new System.Drawing.Point(9, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Management_System.Properties.Resources._127_1279915_png_file_svg_users_icon_font_awesome;
            this.pictureBox1.Location = new System.Drawing.Point(9, 561);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelMenue.ResumeLayout(false);
            this.panelMenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel panelMenue;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button BtnDoctor;
        private System.Windows.Forms.Button BtnNurse;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWlcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnMedicine;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}