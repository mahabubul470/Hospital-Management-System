namespace Hospital_Management_System
{
    partial class ReceptionistForm
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
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnAppointment = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblWlcome = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1671F));
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
            this.panelMenue.BackColor = System.Drawing.SystemColors.Menu;
            this.panelMenue.Controls.Add(this.BtnLogOut);
            this.panelMenue.Controls.Add(this.pictureBox5);
            this.panelMenue.Controls.Add(this.pictureBox4);
            this.panelMenue.Controls.Add(this.pictureBox1);
            this.panelMenue.Controls.Add(this.BtnDoctor);
            this.panelMenue.Controls.Add(this.changePassBtn);
            this.panelMenue.Controls.Add(this.lblAdminName);
            this.panelMenue.Controls.Add(this.BtnPatient);
            this.panelMenue.Controls.Add(this.BtnAppointment);
            this.panelMenue.Controls.Add(this.btnHome);
            this.panelMenue.Controls.Add(this.lblWlcome);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenue.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.panelMenue.Location = new System.Drawing.Point(3, 3);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(171, 1049);
            this.panelMenue.TabIndex = 2;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(14, 812);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(152, 79);
            this.BtnLogOut.TabIndex = 15;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Hospital_Management_System.Properties.Resources.images__1_;
            this.pictureBox5.Location = new System.Drawing.Point(26, 274);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 54);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hospital_Management_System.Properties.Resources._203_2036943_svg_png_icon_my_doctor_icon_png;
            this.pictureBox4.Location = new System.Drawing.Point(26, 416);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Management_System.Properties.Resources._113_1132993_hospital_hospital_icon_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(24, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDoctor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDoctor.FlatAppearance.BorderSize = 2;
            this.BtnDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnDoctor.Location = new System.Drawing.Point(11, 398);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(155, 89);
            this.BtnDoctor.TabIndex = 9;
            this.BtnDoctor.Text = "Doctor";
            this.BtnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDoctor.UseVisualStyleBackColor = false;
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // changePassBtn
            // 
            this.changePassBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changePassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.changePassBtn.Location = new System.Drawing.Point(14, 682);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(152, 79);
            this.changePassBtn.TabIndex = 8;
            this.changePassBtn.Text = "Change Password ";
            this.changePassBtn.UseVisualStyleBackColor = false;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(21, 47);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(129, 42);
            this.lblAdminName.TabIndex = 7;
            this.lblAdminName.Text = "Recep";
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPatient.FlatAppearance.BorderSize = 2;
            this.BtnPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatient.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnPatient.Location = new System.Drawing.Point(14, 259);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(152, 88);
            this.BtnPatient.TabIndex = 6;
            this.BtnPatient.Text = "Patient";
            this.BtnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPatient.UseVisualStyleBackColor = false;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnAppointment
            // 
            this.BtnAppointment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppointment.Location = new System.Drawing.Point(14, 545);
            this.BtnAppointment.Name = "BtnAppointment";
            this.BtnAppointment.Size = new System.Drawing.Size(152, 82);
            this.BtnAppointment.TabIndex = 4;
            this.BtnAppointment.Text = "Appointment ";
            this.BtnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAppointment.UseVisualStyleBackColor = false;
            this.BtnAppointment.Click += new System.EventHandler(this.BtnAppointment_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.FlatAppearance.BorderSize = 5;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.Location = new System.Drawing.Point(9, 127);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(157, 74);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblWlcome
            // 
            this.lblWlcome.AutoSize = true;
            this.lblWlcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlcome.Location = new System.Drawing.Point(21, 21);
            this.lblWlcome.Name = "lblWlcome";
            this.lblWlcome.Size = new System.Drawing.Size(100, 25);
            this.lblWlcome.TabIndex = 1;
            this.lblWlcome.Text = "Welcome,";
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.SystemColors.Control;
            this.Container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(180, 3);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1665, 1049);
            this.Container.TabIndex = 1;
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReceptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelMenue.ResumeLayout(false);
            this.panelMenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel panelMenue;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button BtnAppointment;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWlcome;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.Button BtnDoctor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnLogOut;
    }
}