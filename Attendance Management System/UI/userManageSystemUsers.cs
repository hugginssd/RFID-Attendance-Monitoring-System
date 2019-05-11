using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.DAL;
using Attendance_Management_System.BLL;

namespace Attendance_Management_System.UI
{
    public partial class userManageSystemUsers : UserControl
    {
        public userManageSystemUsers()
        {
            InitializeComponent();
        }
        UserBLL ubll = new UserBLL();
        UserDAL udal = new UserDAL();
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ubll.Active = 1;
                ubll.CreatedBy = 1;
                ubll.ID = Convert.ToInt32(txtID.Text);
                ubll.Password = txtOldPassword.Text;
                ubll.UserName = txtUsername.Text;
                bool IsSuccess = udal.Update(ubll);
                if (IsSuccess)
                {
                    MessageBox.Show("Successfully updated");
                }
                else
                {
                    MessageBox.Show("Failed to initated a record");
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
