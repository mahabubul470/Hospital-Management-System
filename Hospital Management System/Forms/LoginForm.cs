using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hospital_Management_System
{
  public partial class LoginForm : Form
    {
        public static string adminName;
        bool userNameChanged = false;
        bool passwordChanged = false;
        Thread thread;
        static int countClick;
        ForgotPasswordForm forgotForm = new ForgotPasswordForm();
        public LoginForm()
        {
            this.Show();
            InitializeComponent();
            
        }
        public void ResetColor(Color foreColr, Color backColor)
        {
            //BackColor
            UserIdTexBox.BackColor = backColor;
            PasswordTextBox.BackColor = backColor;
            LoginBtn.BackColor = backColor;
            ForgotBtn.BackColor = backColor;
            //ForeColor
            UserIdTexBox.ForeColor = foreColr;
            PasswordTextBox.ForeColor = foreColr;
            LoginBtn.ForeColor = foreColr;
            ForgotBtn.ForeColor = foreColr;
            //Invalid Label
           
        }
        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            ResetColor(Color.DarkCyan, Color.White);
            LoginBtn.BackColor = Color.DarkCyan;
            LoginBtn.ForeColor = Color.White;
            string userId = UserIdTexBox.Text;
            string password = PasswordTextBox.Text;
            string sqlString = @"select * from [User] where [Name]='" + UserIdTexBox.Text.Trim()+"' and [Password]='"+PasswordTextBox.Text.Trim()+"'";
            if (userId == "" || password == "")
            {
                string title = "Empty Fields!";
                string message = "Please insert Username and Password";
                MessageBox.Show(message, title,MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                
            } 
            else if (userId == "Username" || password == "Password")
            {
                string title = "Alert!";
                string message = "Please insert Username and Password";
                MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (DataAcces.LoginCheck(sqlString))
                {
                    DataTable datatable = DataAcces.ExecuteQuery(@"select [User_Type] from [User] where [Name] = '" + UserIdTexBox.Text.Trim() + "' and [password] = '" + PasswordTextBox.Text.Trim() + "'; ");
                    if (datatable.Rows[0][0].ToString().Trim().ToLower().Equals("admin"))
                    {
                        adminName = UserIdTexBox.Text;
                        this.Dispose();
                        thread = new Thread(StartAdminForm);
                        thread.SetApartmentState(ApartmentState.MTA);
                        thread.Start();
                        void StartAdminForm()
                        {
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new AdminForm());
                        }
                    }
                    else if (datatable.Rows[0][0].ToString().Trim().ToLower().Equals("receptionist"))
                    {
                        adminName = UserIdTexBox.Text;
                        this.Dispose();
                        thread = new Thread(StartAdminForm);
                        thread.SetApartmentState(ApartmentState.MTA);
                        thread.Start();
                        void StartAdminForm()
                        {
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new ReceptionistForm());
                        }
                    }
                    else
                        MessageBox.Show(datatable.Rows[0][0].ToString());

                }
                else
                {
                    string title = "Warning";
                    string message = "Wrong Username and Password";
                    MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
            }
        }
        private void UserIdTextBox_Click(object sender, EventArgs e)
        {
            if(UserIdTexBox.Text.Equals("Username"))
            {
                UserIdTexBox.Text = "";
                userNameChanged = true;
            }

            ResetColor(Color.DarkCyan, Color.White);
            UserIdTexBox.BackColor = Color.DarkCyan;
            UserIdTexBox.ForeColor = Color.White;
        }
        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Equals("Password"))
            {
                PasswordTextBox.Text = "";
                passwordChanged = true;
            }
            ResetColor(Color.DarkCyan, Color.White);
            PasswordTextBox.BackColor = Color.DarkCyan;
            PasswordTextBox.ForeColor = Color.White;
        }
        private void loginForm_Load(object sender, EventArgs e)
        {
           
            
        }
        private void ForgotBtn_Click(object sender, EventArgs e)
        {
            ResetColor(Color.DarkCyan, Color.White);
            ForgotBtn.BackColor = Color.DarkCyan;
            ForgotBtn.ForeColor = Color.White;
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.TopMost = true;
            forgotPasswordForm.Show();

        }

        private void UserIdTexBox_TextChanged(object sender, EventArgs e)
        {
            if (UserIdTexBox.Text.Equals("") && userNameChanged)
            {

                UserIdTexBox.Text = "Username";
                userNameChanged = false;
            }
            else if(UserIdTexBox.Text.Equals("Username") && !userNameChanged)
            {
                UserIdTexBox.Text = "";
                userNameChanged = true;
            }
            else
            {
                userNameChanged = true;
            }
        }

        private void PasswordTexBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Equals("") && passwordChanged)
            {

                PasswordTextBox.Text = "Password";
                passwordChanged = false;
            }
            else if (PasswordTextBox.Text.Equals("Password") && !passwordChanged)
            {
                PasswordTextBox.Text = "";
                passwordChanged = true;
            }
            else
            {
                passwordChanged = true;
            }
        }

        private void ShowTextBtn_Click(object sender, EventArgs e)
        {
            if(countClick%2==0)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ShowTextBtn.Text = "Hide";
                
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ShowTextBtn.Text = "Show";
            }

            countClick++;
        }

        private void PasswordTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void InvalidLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
