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
    public partial class ReceptionistForm : Form
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

        private Appointment appointment;
        public Appointment _appointment
        {
            get
            {
                appointment = new Appointment();
                appointment.Dock = DockStyle.Fill;
                appointment.BringToFront();
                return appointment;
            }
        }




        public ReceptionistForm()
        {

            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void lblWlcome_Click(object sender, EventArgs e)
        {

        }

        private void AddPatientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAdminName_Click(object sender, EventArgs e)
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
        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_Click(object sender, EventArgs e)
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

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm().Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit?";
            string caption = "Exit!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message,caption,buttons,MessageBoxIcon.Question);
            if(result == System.Windows.Forms.DialogResult.Yes)
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

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(_appointment);
            _appointment.Show();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            DoctorViewOnly doctor = new DoctorViewOnly();
            doctor.Dock = DockStyle.Fill;
            doctor.BringToFront();
            Container.Controls.Clear();
            Container.Controls.Add(doctor);
            doctor.Show();
        }
    }
}
