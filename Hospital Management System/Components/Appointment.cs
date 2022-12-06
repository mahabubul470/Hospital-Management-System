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
	public partial class Appointment : UserControl
	{
		string selectedId="";
		string  gender;
		public Appointment()
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
			string sql = @"select * from [Appointment]";
			if ( !string.IsNullOrEmpty(SearchTextBpx.Text) && !SearchTextBpx.Text.Equals("Search By Name"))
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
			txtAddress.Text= "";
			txtPhone.Text= "";
			txtEmail.Text= "";
			rbtnFemale.Checked = false;
			rbtnMale.Checked = false;
			selectedId = "";
			
		}
		bool isSelected()
		{
			bool flag = true;
			if (tbxName.Text.Equals("") || txtAddress.Text.Equals("")
				|| txtPhone.Text.Equals(""))
				flag = false;
			if(!rbtnFemale.Checked && !rbtnMale.Checked)
				flag = false;
			return flag;
		}

		void format()
		{

			if (rbtnMale.Checked)
				gender = "Male";
			else
				gender = "Female";

			ReleaseDate.Format = DateTimePickerFormat.Custom;
			ReleaseDate.CustomFormat = "MM-dd-yyyy";
		}

		private void AddPatientBtn_Click(object sender, EventArgs e)
		{

			format();
			if(!isSelected())
			{
				string message = "Please fill up all the fields";
				string title = "Fields Empty";
				MessageBox.Show(message,title,MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				string sqlString = @"INSERT INTO [dbo].[Appointment] ( [Name], [Address], [Phone], [Email], [Gender], [Date], [Appoint_Doctor]) VALUES ( N'test                                              ', N'test      ', N'test                          ', N'test                          ', N'test      ', N'1998-07-17', N'test                                              ')";
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
				string sqlString = @"Delete from [Appointment] where [Id] = " + selectedId + "";
				DataAcces.ExecuteUpdateQuery(sqlString);
				LoadDataBase();
			}
			
		}

		private void UpdatBtn_Click(object sender, EventArgs e)
		{
			if(selectedId=="")
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
				string sqlString = @"UPDATE [dbo].[Appointment]
										SET  [Name]='"+tbxName.Text+@"', [Address]='" + txtAddress.Text + @"', [Phone]='" +txtPhone.Text + @"', [Email]='" + txtEmail.Text + @"', [Gender]='" + gender + @"',  [Date]='" + ReleaseDate.Text + @"', [Appoint_Doctor]='NULL'
										WHERE [Id] = " + selectedId + @"";
				DataAcces.ExecuteUpdateQuery(sqlString);
				LoadDataBase();
			}

		}

		void fillTextBox()
		{
			string sql = @"select * from [Appointment] WHERE  [Id] = "+selectedId+" ";
			DataTable dataTable = DataAcces.ExecuteQuery(sql);
			tbxName.Text = dataTable.Rows[0]["Name"].ToString();
			txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
			txtPhone.Text = dataTable.Rows[0]["Phone"].ToString();
			txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
			ReleaseDate.Text = dataTable.Rows[0]["Date"].ToString();
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
				selectedId = PatientDataGV.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
				fillTextBox();
			}
			catch (Exception ex)
			{

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
