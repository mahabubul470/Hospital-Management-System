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
	public partial class User : UserControl
	{
		string selectedId = "";
		string mStatus, gender,type;
		public User()
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
			string sql = @"select [User_Id],[Name],[Email],[Gender],[Blood_Group],[User_Type],[Phone] from [User]";
			if (!string.IsNullOrEmpty(SearchTextBpx.Text) && !SearchTextBpx.Text.Equals("Search By Name"))
			{
				sql += " where [Name] like '%" + SearchTextBpx.Text + "%'";
				flag = true;
			}
			DataTable dataTable = DataAcces.ExecuteQuery(sql);
			UserDataGV.DataSource = dataTable;
			UserDataGV.Refresh();
			UserDataGV.ClearSelection();
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
			PasswordTbx.Text = "";
			rbtnFemale.Checked = false;
			rbtnMale.Checked = false;
			rbtnMarried.Checked = false;
			rbtnUnmarried.Checked = false;
			rbtnAdmin.Checked = false;
			rbtnReceptionist.Checked = false;
			selectedId = "";
		}
		bool isSelected()
		{
			bool flag = true;
			if (tbxName.Text.Equals("") || PasswordTbx.Text.Equals("") || txtAddress.Text.Equals("")
				|| txtPhone.Text.Equals("") || txtEmail.Text.Equals(""))
				flag = false;
			if (!rbtnFemale.Checked && !rbtnMale.Checked || !rbtnMarried.Checked && !rbtnUnmarried.Checked || !rbtnAdmin.Checked && !rbtnReceptionist.Checked)
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

			if (rbtnAdmin.Checked)
				type = "Admin";
			else
				type = "Receptionist";


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
				string sqlString = @"INSERT INTO [dbo].[User] ( [Name], [Address], [Email], [Password], [Gender], [Blood_Group], [BirthDate], [Joining_Date], [Marritial Status], [User_Type],[Phone]) VALUES (N'"+tbxName.Text+ "', N'"+txtAddress.Text+ "', N'"+txtEmail.Text+ "', N'"+PasswordTbx.Text+ "', N'"+gender+ "', N'"+ cbxBloodGroup.SelectedItem.ToString() + "', N'"+BirthDate.Text+"', N'"+JoiningDate.Text+"', N'"+mStatus+"', N'"+type+ "', N'" + txtPhone.Text + "')";
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
				string sqlString = @"Delete from [User] where [User_Id]= " + selectedId + "";
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
				string sqlString = @"UPDATE [dbo].[User]
										SET  [Name]='" + tbxName.Text + @"', [Address]='" + txtAddress.Text + @"', [Phone]='" + txtPhone.Text + @"', [Email]='" + txtEmail.Text + @"', [Blood_Group]='" + cbxBloodGroup.Text + @"', [Gender]='" + gender + @"', [BirthDate]='" + BirthDate.Text + @"', [Password]='" + PasswordTbx.Text + @"', [Joining_Date]='" + JoiningDate.Text + @"', [User_Type]='" + type + @"', [Marritial Status]='" + mStatus + @"'
										WHERE [User_Id] = " + selectedId + @"";
				DataAcces.ExecuteUpdateQuery(sqlString);
				LoadDataBase();
			}

		}

		void fillTextBox()
		{
			string sql = @"select * from [USER] WHERE  [User_Id] = " + selectedId + " ";
			DataTable dataTable = DataAcces.ExecuteQuery(sql);
			tbxName.Text = dataTable.Rows[0]["Name"].ToString().Trim();
			PasswordTbx.Text = dataTable.Rows[0]["Password"].ToString().Trim();
			txtAddress.Text = dataTable.Rows[0]["Address"].ToString().Trim();
			txtAddress.Text = dataTable.Rows[0]["Address"].ToString().Trim();
			txtPhone.Text = dataTable.Rows[0]["Phone"].ToString().Trim();
			txtEmail.Text = dataTable.Rows[0]["Email"].ToString().Trim();
			BirthDate.Text = dataTable.Rows[0]["BirthDate"].ToString().Trim();
			JoiningDate.Text = dataTable.Rows[0]["Joining_Date"].ToString().Trim();
			cbxBloodGroup.SelectedItem = dataTable.Rows[0]["Blood_Group"].ToString().Trim();
			if (dataTable.Rows[0]["Marritial Status"].ToString().Trim() == "Married")
			{
				rbtnMarried.Checked = true;
				mStatus = "Married";
			}
			else
			{
				mStatus = "Unmarried";
				rbtnUnmarried.Checked = true;
			}
			if (dataTable.Rows[0]["Gender"].ToString().Trim() == "Male")
			{
				rbtnMale.Checked = true;
				gender = "Male";
			}
			else
			{
				rbtnFemale.Checked = true;
				gender = "Female";
			}
			if (dataTable.Rows[0]["User_Type"].ToString().Trim() == "Admin")
			{
				rbtnAdmin.Checked = true;
				type = "Admin";
			}
			else
			{
				rbtnReceptionist.Checked = true;
				type = "Receptionist";
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
			new UserInfoForm().Show();
		}

		private void UserDataGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				selectedId = UserDataGV.Rows[e.RowIndex].Cells["userIdDataGridViewTextBoxColumn"].Value.ToString();
				fillTextBox();
			}
			catch (Exception ex)
			{

			}
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
