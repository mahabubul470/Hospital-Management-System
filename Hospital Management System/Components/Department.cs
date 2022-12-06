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
	public partial class Department : UserControl
	{
		string selectedId = "";
		string mStatus, gender;
		public Department()
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
			string sql = @"select [Patient_Id],[Name],[Address],[Phone],[BloodGroup],[Gender],[Date_of_birth],[Assigned_Docotor],[Assigned_Nurse] from Patient";
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

		void refreshText()
		{
			tbxName.Text = "";
			txtGurdian.Text = "";
			txtAddress.Text = "";
			txtPhone.Text = "";
			txtEmail.Text = "";
			rbtnFemale.Checked = false;
			rbtnMale.Checked = false;
			rbtnMarried.Checked = false;
			rbtnUnmarried.Checked = false;
			selectedId = "";
		}
		bool isSelected()
		{
			bool flag = true;
			if (tbxName.Text.Equals("") || txtGurdian.Text.Equals("") || txtAddress.Text.Equals("")
				|| txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || diseaseTxtbx.Text.Equals(""))
				flag = false;
			if (!rbtnFemale.Checked && !rbtnMale.Checked || !rbtnMarried.Checked && !rbtnUnmarried.Checked)
				flag = false;
			if (cbxBloodGroup.SelectedIndex < 0)
				flag = false;
			return flag;
		}

		void format()
		{
			if (rbtnMarried.Checked)
				mStatus = "Married";
			else
				mStatus = "Unarried";

			if (rbtnMale.Checked)
				gender = "Male";
			else
				gender = "Female";

			BirthDate.Format = DateTimePickerFormat.Custom;
			BirthDate.CustomFormat = "MM-dd-yyyy";
			ArrivalDate.Format = DateTimePickerFormat.Custom;
			ArrivalDate.CustomFormat = "MM-dd-yyyy";
			ReleaseDate.Format = DateTimePickerFormat.Custom;
			ReleaseDate.CustomFormat = "MM-dd-yyyy";
		}

		private void AddPatientBtn_Click(object sender, EventArgs e)
		{

			format();
			if (!isSelected())
			{
				string message = "Please fill up all the fields";
				string title = "Fields Empty";
				MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				string sqlString = @"INSERT INTO [dbo].[Patient] ([Name], [Address], [Phone], [Email], [BloodGroup], [Gender], [Date_of_birth], [Disease], [Arraival_date], [Discharged_date], [Guardian_Name], [Marretial_Status], [Assigned_Nurse], [Assigned_Docotor], [Room_No]) VALUES ( N'" + tbxName.Text + "', N'" + txtAddress.Text + "', N'" + txtPhone.Text + "', N'" + txtEmail.Text + "', N'" + cbxBloodGroup.SelectedItem.ToString() + "', N'" + gender + "', N'" + BirthDate.Text + "', N'" + diseaseTxtbx.Text + "', N'" + ArrivalDate.Text + "', N'" + ReleaseDate.Text + "', N'" + txtGurdian.Text + "', N'" + mStatus + "', NULL, NULL, NULL)";
				DataAcces.ExecuteUpdateQuery(sqlString);
				LoadDataBase();
			}


		}

		private void button2_Click(object sender, EventArgs e)
		{

			if (selectedId == "")
			{
				string message = "Please select a row first";
				string title = "Select!";
				MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				string sqlString = @"Delete from Patient where [Patient_Id] = " + selectedId + "";
				DataAcces.ExecuteUpdateQuery(sqlString);
				LoadDataBase();
			}

		}

		private void UpdatBtn_Click(object sender, EventArgs e)
		{
			if (selectedId == "")
			{
				string message = "Please select a row first";
				string title = "Select!";
				MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (!isSelected())
			{
				string message = "Please fill up all the fields";
				string title = "Fields Empty";
				MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				format();
				string sqlString = @"UPDATE [dbo].[Patient]
										SET  [Name]='" + tbxName.Text + @"', [Address]='" + txtAddress.Text + @"', [Phone]='" + txtPhone.Text + @"', [Email]='" + txtEmail.Text + @"', [BloodGroup]='" + cbxBloodGroup.Text + @"', [Gender]='" + gender + @"', [Date_of_birth]='" + BirthDate.Text + @"', [Disease]='" + diseaseTxtbx.Text + @"', [Arraival_date]='" + ArrivalDate.Text + @"', [Discharged_date]='" + ReleaseDate.Text + @"', [Guardian_Name]='" + txtGurdian.Text + @"', [Marretial_Status]='" + mStatus + @"', [Assigned_Nurse]=NULL, [Assigned_Docotor]=NULL, [Room_No]=NULL
										WHERE [Patient_Id] = " + selectedId + @"";
				DataAcces.ExecuteUpdateQuery(sqlString);
				LoadDataBase();
			}

		}

		void fillTextBox()
		{
			string sql = @"select * from Patient WHERE  [Patient_Id] = " + selectedId + " ";
			DataTable dataTable = DataAcces.ExecuteQuery(sql);
			tbxName.Text = dataTable.Rows[0]["Name"].ToString();
			txtGurdian.Text = dataTable.Rows[0]["Guardian_Name"].ToString();
			txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
			txtPhone.Text = dataTable.Rows[0]["Phone"].ToString();
			txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
			cbxBloodGroup.SelectedItem = dataTable.Rows[0]["BloodGroup"].ToString();
			if (dataTable.Rows[0]["Marretial_Status"].ToString() == "Married")
			{
				rbtnMarried.Checked = true;
				mStatus = "Married";
			}
			else
			{
				mStatus = "Married";
				rbtnUnmarried.Checked = true;
			}
			if (dataTable.Rows[0]["Gender"].ToString() == "Male")
			{
				rbtnMale.Checked = true;
				gender = "Male";
			}
			else
			{
				rbtnFemale.Checked = true;
				gender = "Female";
			}
		}

		private void PatientDataGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{

			try
			{
				selectedId = PatientDataGV.Rows[e.RowIndex].Cells["patientIdDataGridViewTextBoxColumn"].Value.ToString();
				fillTextBox();
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
		private void SearchTextBpx_Click_1(object sender, EventArgs e)
		{
			SearchTextBpx.Text = "";
		}
		private void RefreshBtn_Click(object sender, EventArgs e)
		{
			LoadDataBase();
			refreshText();
		}

		private void ViewAllBtn_Click(object sender, EventArgs e)
		{
			new PatientInfoForm().Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			LoadDataBase();
		}

	}
}
