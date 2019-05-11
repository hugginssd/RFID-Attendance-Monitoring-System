using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.BLL;
using Attendance_Management_System.DAL;

namespace Attendance_Management_System.UI
{
    public partial class userSystemUsers : UserControl
    {
        public userSystemUsers()
        {
            InitializeComponent();
        }
        UserDAL udal = new UserDAL();
        UserBLL ubll = new UserBLL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ubll.Active = 1;
                ubll.CreatedBy = 1;
                ubll.ID = Convert.ToInt32(txtID.Text);
                ubll.LastName = txtLastname.Text.ToUpper();
                ubll.Name = txtFirstname.Text.ToUpper();
                ubll.Role = CmbRoles.Text.ToUpper();
                ubll.Password = txtPassword.Text;
                ubll.UserName = txtUsername.Text;
                bool IsSuccess = udal.Insert(ubll);
                if (IsSuccess)
                {
                    MessageBox.Show("Successfully created");
                    DataTable dt = new DataTable();
                    dt = udal.Select(txtUsername.Text.Trim());
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Failed to initiate a record");
                }   
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.ToString(),"UI error");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = udal.Select(TxtSearch.Text.Trim());
            dataGridView1.DataSource = dt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = udal.Select(TxtSearch.Text.Trim());
            dataGridView1.DataSource = dt;
        }
    }
}
