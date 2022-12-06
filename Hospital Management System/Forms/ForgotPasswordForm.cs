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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }




        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string sqlString = @"select email from SystemUser where [Email ]='" + MailTextBox.Text + "';";
            string userMail = MailTextBox.Text;
            if (!userMail.Contains("@") && !userMail.Contains(".com"))
                PasswordLabel.Text = "Invalid Email Format";
            else if (DataAcces.LoginCheck(sqlString))
            {
                string sqlStringPass = @"select [Password] from SystemUser where [Email ]='" + MailTextBox.Text + "';";
                DataTable dataTable = DataAcces.ExecuteQuery(sqlStringPass);
                string userPassword = dataTable.Rows[0][0].ToString().Trim();
                PasswordLabel.Text = DataAcces.Email(userMail,userPassword);
                tempLbl.Text = "Your user password has been sent to your email address";
            }
            else
                 PasswordLabel.Text = "Provided email is not registered";
            


            //DataAcces dataAcces = new DataAcces();
            //string sqlString = "select Password from SystemUser where [Email ] = '"+userMail+"' ";
            //string UserPassword = dataAcces.ForgotPassword(sqlString);
            //if (MailTextBox.Text.Equals("Enter your email"))
            //    PasswordLabel.Text = "Invalid Email";
            //else if (MailTextBox.Text.Equals(""))
            //    PasswordLabel.Text = "Fild Empty";
            //else if (UserPassword == "Not an User")
            //    PasswordLabel.Text = "Not an User";
            //else PasswordLabel.Text = "Password : "+UserPassword;
        }

        private void MailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailTextBox_Click(object sender, EventArgs e)
        {

            if (MailTextBox.Text.Equals("Enter your email"))
                MailTextBox.Text = "";
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            PasswordLabel.Text = "";
            tempLbl.Text = "";
        }
    }
}
