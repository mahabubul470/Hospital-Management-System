using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class AdminForm : Form
    {
        Thread thread;
        private Home home;

        public Home _home
        {
            get 
            {
                home = new Home();
                home.Dock = DockStyle.Fill;
                home.BringToFront();
                return home; 
            }
        }

        private Patient patient;
        public Patient _patient
        {
            get
            {
                patient = new Patient();
                patient.Dock = DockStyle.Fill;
                patient.BringToFront();
                return patient;
            }
        }

        private User user;
        public User _user
        {
            get
            {
                user = new User();
                user.Dock = DockStyle.Fill;
                user.BringToFront();
                return user;
            }
        }



        public AdminForm()
        {
            
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(_home);
            _home.Show();
        }

        private void AddPatientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospital_DBDataSet.Patient' table. You can move, or remove it, as needed.
            
            lblAdminName.Text = LoginForm.adminName.ToUpper();
            Container.Controls.Clear();
            Container.Controls.Add(_home);
            _home.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(_patient);
            _patient.Show();
            
           
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(_home);
            _home.Show();


        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(_user);
            _user.Show();

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit?";
            string caption = "Exit!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                thread = new Thread(Start);
                thread.SetApartmentState(ApartmentState.MTA);
                thread.Start();
                void Start()
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new LoginForm());
                }
            }
        }

        private void BtnMedicine_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.Dock = DockStyle.Fill;
            medicine.BringToFront();
            Container.Controls.Clear();
            Container.Controls.Add(medicine);
            medicine.Show();
        }

        private void BtnNurse_Click(object sender, EventArgs e)
        {
            Nurse nurse  = new Nurse();
            nurse.Dock = DockStyle.Fill;
            nurse.BringToFront();
            Container.Controls.Clear();
            Container.Controls.Add(nurse);
            nurse.Show();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Dock = DockStyle.Fill;
            doctor.BringToFront();
            Container.Controls.Clear();
            Container.Controls.Add(doctor);
            doctor.Show();
        }
    }
}
