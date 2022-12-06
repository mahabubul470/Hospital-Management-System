using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void DescriptionTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadPatient();
            loadDoctor();
            loadNurse();
        }

        void loadPatient()
        {
            string sqlString = "SELECT COUNT(*) FROM[Patient]";
            totalPatient.Text = countDb(sqlString);
        }

        void loadDoctor()
        {
            string sqlString = "SELECT COUNT(*) FROM[Doctor]";
            totalDoctor.Text = countDb(sqlString);
        }

        void loadNurse()
        {
            string sqlString = "SELECT COUNT(*) FROM[Nurse]";
            totalNurse.Text = countDb(sqlString);
        }

        string countDb(string sqlString)
        {
            DataTable dataTable =  DataAcces.ExecuteQuery(sqlString);
            return dataTable.Rows[0][0].ToString();
        }
    }
}
