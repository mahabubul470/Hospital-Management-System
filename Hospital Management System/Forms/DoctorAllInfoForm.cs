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
    public partial class DoctorAllInfoForm : Form
    {
        public DoctorAllInfoForm()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.panel1.Height, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void PatientInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'docotorBataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.docotorBataSet.Doctor);
            // TODO: This line of code loads data into the 'docotorBataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.docotorBataSet.Doctor);
            // TODO: This line of code loads data into the 'docotorBataSet.Doctor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'docotorBataSet.Doctor' table. You can move, or remove it, as needed.
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
