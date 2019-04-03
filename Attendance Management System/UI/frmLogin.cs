using Attendance_Management_System.BLL;
using Attendance_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        userBLL userBLL = new userBLL();
        userDAL userDAL = new userDAL();

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace( txtPassword.Text))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            userBLL.UserName = txtUsername.Text;
            userBLL.Password = txtPassword.Text;
            bool success = userDAL.Search(userBLL);
            if (success)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details.");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblAdmin.Visible = true;
        }
    }
}
