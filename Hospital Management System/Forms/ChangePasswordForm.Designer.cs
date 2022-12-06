namespace Hospital_Management_System
{
    partial class ChangePasswordForm
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
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblMatch = new System.Windows.Forms.Label();
            this.blbConfermPassword = new System.Windows.Forms.Label();
            this.tbxConfermNewPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxCurrPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.ShowPassBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.Location = new System.Drawing.Point(276, 139);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(256, 30);
            this.tbxUserName.TabIndex = 16;
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.ForeColor = System.Drawing.Color.Maroon;
            this.lblMatch.Location = new System.Drawing.Point(289, 318);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(231, 25);
            this.lblMatch.TabIndex = 15;
            this.lblMatch.Text = "Password doesnot match";
            this.lblMatch.Visible = false;
            // 
            // blbConfermPassword
            // 
            this.blbConfermPassword.AutoSize = true;
            this.blbConfermPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbConfermPassword.Location = new System.Drawing.Point(24, 265);
            this.blbConfermPassword.Name = "blbConfermPassword";
            this.blbConfermPassword.Size = new System.Drawing.Size(222, 25);
            this.blbConfermPassword.TabIndex = 14;
            this.blbConfermPassword.Text = "Conferm New Password";
            // 
            // tbxConfermNewPassword
            // 
            this.tbxConfermNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfermNewPassword.Location = new System.Drawing.Point(276, 268);
            this.tbxConfermNewPassword.Name = "tbxConfermNewPassword";
            this.tbxConfermNewPassword.Size = new System.Drawing.Size(256, 30);
            this.tbxConfermNewPassword.TabIndex = 13;
            this.tbxConfermNewPassword.UseSystemPasswordChar = true;
            this.tbxConfermNewPassword.TextChanged += new System.EventHandler(this.tbxNewPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(78, 184);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(168, 25);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Current Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(144, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 25);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Username";
            // 
            // tbxCurrPassword
            // 
            this.tbxCurrPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrPassword.Location = new System.Drawing.Point(276, 184);
            this.tbxCurrPassword.Name = "tbxCurrPassword";
            this.tbxCurrPassword.Size = new System.Drawing.Size(256, 30);
            this.tbxCurrPassword.TabIndex = 10;
            this.tbxCurrPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "New Password";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPassword.Location = new System.Drawing.Point(276, 225);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(256, 30);
            this.tbxNewPassword.TabIndex = 17;
            this.tbxNewPassword.UseSystemPasswordChar = true;
            this.tbxNewPassword.TextChanged += new System.EventHandler(this.tbxNewPassword_TextChanged);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(370, 376);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(162, 48);
            this.BtnSubmit.TabIndex = 19;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // ShowPassBtn
            // 
            this.ShowPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassBtn.Location = new System.Drawing.Point(547, 184);
            this.ShowPassBtn.Name = "ShowPassBtn";
            this.ShowPassBtn.Size = new System.Drawing.Size(102, 30);
            this.ShowPassBtn.TabIndex = 20;
            this.ShowPassBtn.Text = "Show";
            this.ShowPassBtn.UseVisualStyleBackColor = true;
            this.ShowPassBtn.Click += new System.EventHandler(this.ShowPassBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(160, 376);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(162, 48);
            this.RefreshBtn.TabIndex = 21;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 529);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ShowPassBtn);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.blbConfermPassword);
            this.Controls.Add(this.tbxConfermNewPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxCurrPassword);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label blbConfermPassword;
        private System.Windows.Forms.TextBox tbxConfermNewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxCurrPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button ShowPassBtn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}