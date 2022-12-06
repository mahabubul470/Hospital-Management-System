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
	public partial class Doctor : UserControl
	{
		string selectedId = "";
		string mStatus, gender;
		public Doctor()
		{
			InitializeComponent();
		}

		private void Patient_Load(object sender, EventArgs e)
		{

			LoadDataBase();
			FillComboBox();
		}

		void FillComboBox()
		{
			string sqlString = "select [Name] from [Patient]";
			DataTable table = DataAcces.ExecuteQuery(sqlString);
			cmbPatient.DisplayMember = "Name";
			cmbPatient.ValueMember = "Name";
			cmbPatient.DataSource = table;

		}

		string getPatient()
		{
			DataRowView dataRow = cmbPatient.SelectedItem as DataRowView;
			string sValue = string.Empty;
			if (dataRow != null)
			{

				sValue = dataRow.Row["Name"] as string;
			}
			return sValue;
		}

		private void LoadDataBase()
		{
			bool flag = false;
			string sql = @"select [Doctor_Id],[Name],[Phone],[Email],[Gender],[Blood_Group],[Assigned_Patiend],[Speciality],[Designation] from [Doctor]";
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
			//txtGurdian.Text = "";
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
			if (tbxName.Text.Equals("") || tbxDesignation.Text.Equals("") || txtAddress.Text.Equals("")
				|| txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || tbxSpeciality.Text.Equals(""))
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
				//string sqlString = @"INSERT INTO [dbo].[Patient] ([Name], [Address], [Phone], [Email], [BloodGroup], [Gender], [Date_of_birth], [Disease], [Arraival_date], [Discharged_date], [Guardian_Name], [Marretial_Status], [Assigned_Nurse], [Assigned_Docotor], [Room_No]) VALUES ( N'" + tbxName.Text + "', N'" + txtAddress.Text + "', N'" + txtPhone.Text + "', N'" + txtEmail.Text + "', N'" + cbxBloodGroup.SelectedItem.ToString() + "', N'" + gender + "', N'" + BirthDate.Text + "', N'" + diseaseTxtbx.Text + "', N'" + ArrivalDate.Text + "', N'" + ReleaseDate.Text + "', N'" + txtGurdian.Text + "', N'" + mStatus + "', NULL, NULL, NULL)";
				string sqlString = @"INSERT INTO [dbo].[Doctor] ( [Name], [Address], [Phone], [Email], [Gender], [Blood_Group], [BirthDate], [Joining Date], [Marretial_Status], [Assigned_Patiend], [Speciality],[Designation]) VALUES (N'"+tbxName.Text+ "', N'" + txtAddress.Text + "', N'" + txtPhone.Text + "', N'" +txtEmail.Text + "', N'" + gender+ "', N'" +cbxBloodGroup.SelectedItem.ToString() + "', N'"+BirthDate.Text+"', N'"+JoiningDate.Text+"', N'"+mStatus+ "', N'" + getPatient() + "', N'" + tbxSpeciality.Text+"', N'"+tbxDesignation.Text+"')";
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
				string sqlString = @"Delete from [Doctor] where [Doctor_Id] = " + selectedId + "";
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
				string sqlString = @"UPDATE [dbo].[Doctor]
										SET  [Name]='" + tbxName.Text + @"', [Address]='" + txtAddress.Text + @"', [Phone]='" + txtPhone.Text + @"', [Email]='" + txtEmail.Text + @"', [Blood_Group]='" + cbxBloodGroup.Text + @"', [Gender]='" + gender + @"', [BirthDate]='" + BirthDate.Text + @"', [Joining Date]='" + JoiningDate.Text + @"', [Speciality]='" + tbxSpeciality.Text + @"', [Designation]='" + tbxDesignation.Text + @"', [Marretial_Status]='" + mStatus + @"', [Assigned_Patiend]='"+getPatient()+@"'
										WHERE [Doctor_Id] = " + selectedId + @"";
				DataAcces.ExecuteUpdateQuery(sqlString);
				LoadDataBase();
			}

		}

		void fillTextBox()
		{
			string sql = @"select * from Doctor WHERE  [Doctor_Id] = " + selectedId + " ";
			DataTable dataTable = DataAcces.ExecuteQuery(sql);
			tbxName.Text = dataTable.Rows[0]["Name"].ToString();
			//txtGurdian.Text = dataTable.Rows[0]["Guardian_Name"].ToString();
			txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
			txtPhone.Text = dataTable.Rows[0]["Phone"].ToString();
			txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
			cbxBloodGroup.SelectedItem = dataTable.Rows[0]["Blood_Group"].ToString();
			tbxDesignation.Text = dataTable.Rows[0]["Designation"].ToString();
			tbxSpeciality.Text = dataTable.Rows[0]["Speciality"].ToString();
			cmbPatient.SelectedItem = dataTable.Rows[0]["Assigned_Patiend"].ToString();
			if (dataTable.Rows[0]["Marretial_Status"].ToString().Trim() == "Married")
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
				selectedId = PatientDataGV.Rows[e.RowIndex].Cells["ID"].Value.ToString();
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
			new DoctorAllInfoForm().Show();
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
