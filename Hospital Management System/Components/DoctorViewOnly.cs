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
	public partial class DoctorViewOnly : UserControl
	{
		string selectedId = "";
		string mStatus, gender;
		public DoctorViewOnly()
		{
			InitializeComponent();
		}

		private void Patient_Load(object sender, EventArgs e)
		{

			LoadDataBase();
		}
		private void LoadDataBase()
		{
			bool flag = false;
			string sql = @"select [Doctor_Id],[Name],[Phone],[Email],[Assigned_Patiend],[Gender],[Blood_Group],[Speciality],[Designation] from [Doctor]";
			if (!string.IsNullOrEmpty(SearchTextBpx.Text) && !SearchTextBpx.Text.Equals("Search By Name"))
			{
				sql += " where [Name] like '%" + SearchTextBpx.Text + "%'";
				flag = true;
			}
			DataTable dataTable = DataAcces.ExecuteQuery(sql);
			PatientDataGV.DataSource = dataTable;
			PatientDataGV.Refresh();
			PatientDataGV.ClearSelection();
			if (flag)
				SearchTextBpx.Text = "Search By Name";
		}

		


		private void SearchTextBpx_Click_1(object sender, EventArgs e)
		{
			SearchTextBpx.Text = "";
		}
		private void RefreshBtn_Click(object sender, EventArgs e)
		{
			LoadDataBase();
		
		}

		private void ViewAllBtn_Click(object sender, EventArgs e)
		{
			new DoctorAllInfoForm().Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void OperationPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			LoadDataBase();
		}

	}
}
