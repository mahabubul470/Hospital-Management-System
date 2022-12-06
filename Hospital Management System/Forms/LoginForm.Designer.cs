namespace Hospital_Management_System
{
    partial class LoginForm
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
            this.PasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ForgotBtn = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UserIdTexBox = new System.Windows.Forms.TextBox();
            this.ShowTextBtn = new System.Windows.Forms.Button();
            this.lblHospital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.PasswordTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.PasswordTextBox.Location = new System.Drawing.Point(145, 350);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PromptChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(401, 41);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PasswordTextBox_MaskInputRejected);
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTexBox_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBtn.Location = new System.Drawing.Point(146, 442);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(125, 46);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ForgotBtn
            // 
            this.ForgotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ForgotBtn.Location = new System.Drawing.Point(313, 442);
            this.ForgotBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ForgotBtn.Name = "ForgotBtn";
            this.ForgotBtn.Size = new System.Drawing.Size(233, 46);
            this.ForgotBtn.TabIndex = 3;
            this.ForgotBtn.Text = "Forgot Password?";
            this.ForgotBtn.UseVisualStyleBackColor = true;
            this.ForgotBtn.Click += new System.EventHandler(this.ForgotBtn_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Teal;
            this.LoginLabel.Location = new System.Drawing.Point(254, 174);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(161, 36);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "User Login";
            // 
            // UserIdTexBox
            // 
            this.UserIdTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdTexBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.UserIdTexBox.Location = new System.Drawing.Point(146, 273);
            this.UserIdTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserIdTexBox.Name = "UserIdTexBox";
            this.UserIdTexBox.Size = new System.Drawing.Size(400, 37);
            this.UserIdTexBox.TabIndex = 6;
            this.UserIdTexBox.Text = "Username";
            this.UserIdTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserIdTexBox.Click += new System.EventHandler(this.UserIdTextBox_Click);
            this.UserIdTexBox.TextChanged += new System.EventHandler(this.UserIdTexBox_TextChanged);
            this.UserIdTexBox.Enter += new System.EventHandler(this.UserIdTextBox_Click);
            // 
            // ShowTextBtn
            // 
            this.ShowTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShowTextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTextBtn.Location = new System.Drawing.Point(564, 353);
            this.ShowTextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ShowTextBtn.Name = "ShowTextBtn";
            this.ShowTextBtn.Size = new System.Drawing.Size(75, 41);
            this.ShowTextBtn.TabIndex = 8;
            this.ShowTextBtn.Text = "Show";
            this.ShowTextBtn.UseVisualStyleBackColor = true;
            this.ShowTextBtn.Click += new System.EventHandler(this.ShowTextBtn_Click);
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospital.ForeColor = System.Drawing.Color.Teal;
            this.lblHospital.Location = new System.Drawing.Point(140, 92);
            this.lblHospital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(407, 36);
            this.lblHospital.TabIndex = 9;
            this.lblHospital.Text = "Hospital Management System";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(743, 640);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.ShowTextBtn);
            this.Controls.Add(this.UserIdTexBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.ForgotBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoginForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.MaskedTextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ForgotBtn;
        private System.Windows.Forms.Label LoginLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox UserIdTexBox;
        private System.Windows.Forms.Button ShowTextBtn;
        private System.Windows.Forms.Label lblHospital;
    }
}


