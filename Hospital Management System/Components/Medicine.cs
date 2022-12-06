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
    public partial class Medicine : UserControl
    {
        string selectedId = "";
        public Medicine()
        {
            InitializeComponent();
        }

        private void Medicine_Load(object sender, EventArgs e)
        {

            LoadDataBase();
        }

        private void LoadDataBase()
        {
            bool flag = false;
            string sql = @"select * from Medicine";
            if (!string.IsNullOrEmpty(SearchTextBpx.Text) && !SearchTextBpx.Text.Equals("Search By Name"))
            {
                sql += " where [Medicine_Name] like '%" + SearchTextBpx.Text + "%'";
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
            tbxMName.Text = "";
            txtMCode.Text = "";
            txtMCategory.Text = "";
            txtCName.Text = "";
            txtCPhone.Text = "";
            txtCEmail.Text = "";
            selectedId = "";
        }

        bool isSelected()
        {
            bool flag = true;
            if (tbxMName.Text.Equals("") || txtMCode.Text.Equals("") || txtMCategory.Text.Equals("")
                || txtCName.Text.Equals("") || txtCPhone.Text.Equals("") || txtCEmail.Text.Equals(""))
                flag = false;
            return flag;
        }

        void format()
        {
            ExpireDate.Format = DateTimePickerFormat.Custom;
            ExpireDate.CustomFormat = "MM-dd-yyyy";
            ArrivalDate.Format = DateTimePickerFormat.Custom;
            ArrivalDate.CustomFormat = "MM-dd-yyyy";
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
                string sqlString = @"INSERT INTO [dbo].[Medicine] ([Medicine_Name],[Medicine_Code],[Medicine_Category],[Company_Name],[Company_Phone],[Company_Email],[Arrival_Date],[ExpireDate]) VALUES ( N'" + tbxMName.Text + "', N'" + txtMCode.Text + "', N'" + txtMCategory.Text + "', N'" + txtCName.Text + "', N'" + txtCPhone.Text + "', N'" + txtCEmail.Text + "', N'" + ArrivalDate.Text + "', N'" + ExpireDate.Text + "')";
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
                string sqlString = @"Delete from Medicine where [Id] = " + selectedId + "";
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
                string sqlString = @"UPDATE [dbo].[Medicine]
										SET  [Medicine_Name]='" + tbxMName.Text + @"', [Medicine_Code]='" + txtMCode.Text + @"', [Medicine_Category]='" + txtMCategory.Text + @"', [Company_Name]='" + txtCName.Text + @"', [Company_Phone]='" + txtCPhone.Text + @"', [Company_Email]='" + txtCEmail.Text + @"', [Arrival_Date]='" + ArrivalDate.Text + @"', [ExpireDate]='" + ExpireDate.Text + @"'
										WHERE [Id] = " + selectedId + @"";
                DataAcces.ExecuteUpdateQuery(sqlString);
                LoadDataBase();
            }
        }

        void fillTextBox()
        {
            string sql = @"select * from Medicine WHERE  [Id] = " + selectedId + " ";
            DataTable dataTable = DataAcces.ExecuteQuery(sql);
            tbxMName.Text = dataTable.Rows[0]["Medicine_Name"].ToString();
            txtMCode.Text = dataTable.Rows[0]["Medicine_Code"].ToString();
            txtMCategory.Text = dataTable.Rows[0]["Medicine_Category"].ToString();
            txtCName.Text = dataTable.Rows[0]["Company_Name"].ToString();
            txtCPhone.Text = dataTable.Rows[0]["Company_Phone"].ToString();
            txtCEmail.Text = dataTable.Rows[0]["Company_Email"].ToString();
        }

        private void PatientDataGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                selectedId = PatientDataGV.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }
    }
}
