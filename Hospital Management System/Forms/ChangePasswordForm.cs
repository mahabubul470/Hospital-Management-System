using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class ChangePasswordForm : Form
    {
        static int countClick;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            lblMatch.Visible = false;
        }

        private void tbxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!tbxNewPassword.Text.Equals(tbxConfermNewPassword.Text))
            {
                lblMatch.Visible = true;
            }
            else
                lblMatch.Visible = false;

        }

        bool isEmpty()
        {
            if (tbxConfermNewPassword.Text == "" ||
            tbxCurrPassword.Text == "" ||
            tbxNewPassword.Text == "" ||
            tbxUserName.Text == "")
                return true;
            else
                return false;

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {
                string title = "Empty!";
                string message = "Fields Empty";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sqlLogin = "Select * from [User] Where [Name] = '" + tbxUserName.Text + "' and [Password] = '" + tbxCurrPassword.Text + "'";
                if (DataAcces.LoginCheck(sqlLogin) && !lblMatch.Visible && !tbxNewPassword.Text.Equals(""))
                {
                    string sqlString = "Update [User] Set [Password] = '"+tbxConfermNewPassword.Text.Trim()+"' Where [Name]= '"+tbxUserName.Text.Trim()+"' and [Password]= '"+tbxCurrPassword.Text.Trim()+"'";
                    DataAcces.ExecuteUpdateQuery(sqlString);
                    string title = "Success";
                    string message = "Password Change Successful";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string title = "Error";
                    string message = "Username or Password doesn't match";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ShowPassBtn_Click(object sender, EventArgs e)
        {


            if (countClick % 2 == 0)
            {
                tbxCurrPassword.UseSystemPasswordChar = false;
                tbxNewPassword.UseSystemPasswordChar = false;
                tbxConfermNewPassword.UseSystemPasswordChar = false;
                ShowPassBtn.Text = "Hide";

            }
            else
            {
                tbxCurrPassword.UseSystemPasswordChar = true;
                tbxNewPassword.UseSystemPasswordChar = true;
                tbxConfermNewPassword.UseSystemPasswordChar = true;
                ShowPassBtn.Text = "Show";
            }

            countClick++;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

            tbxConfermNewPassword.Text = "";
            tbxCurrPassword.Text = "";
            tbxNewPassword.Text = "";
            tbxUserName.Text = "";
        }
    }
}
