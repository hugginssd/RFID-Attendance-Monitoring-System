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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lblClose.Visible = false;
            lblMaximize.Visible = false;
           this.Size = new Size(1100, 563);
        }
        int i = 1;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           // Search_Text.AddIcon(txtSearch, Properties.Resources.search);
        }
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want o exit the system?","Quit",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNewStudent.Visible = false;
            btnManageStudent.Visible = false;
            btnNoticeBoard.Visible = true;
            btnSystemUsers.Visible = true;
            userDashboard.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void lblMaximize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1300,600);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlSidePanel.BackColor = Color.Wheat;
            pnlSidePanel.Location = new Point(0, 69);
            pnlSidePanel.Size = new Size(7, btnDashboard.Height);
            useDashboard.Visible = true;
        }

        private void btnStudentDetails_Click(object sender, EventArgs e)
        {  
            pnlSidePanel.Location = new Point(0, 228);
            pnlSidePanel.Size = new Size(7, btnStudentDetails.Height);
           i = i + 1;
            if ((i%2)==0)
            {
                btnNewStudent.Visible = true;
                btnManageStudent.Visible = true;
                btnNoticeBoard.Visible = false;
                btnSystemUsers.Visible = false;
                
            }
            else
            {
                btnNewStudent.Visible = false;
                btnManageStudent.Visible = false;
                btnNoticeBoard.Visible = true;
                btnSystemUsers.Visible = true;
            }
         
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            pnlSidePanel.BackColor = Color.Wheat;
            pnlSidePanel.Location = new Point(0, 122);
            pnlSidePanel.Size = new Size(7, btnAdministration.Height);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pnlSidePanel.BackColor = Color.Wheat;
            pnlSidePanel.Location = new Point(0,175);
            pnlSidePanel.Size = new Size(7, btnAttendance.Height);
        }

        private void btnNoticeBoard_Click(object sender, EventArgs e)
        {
            pnlSidePanel.BackColor = Color.Wheat;
            pnlSidePanel.Location = new Point(0,281);
            pnlSidePanel.Size = new Size(7, btnNoticeBoard.Height);
        }

        private void btnSystemUsers_Click(object sender, EventArgs e)
        {
            pnlSidePanel.BackColor = Color.Wheat;
            pnlSidePanel.Location = new Point(0, 334);
            pnlSidePanel.Size = new Size(7, btnSystemUsers.Height);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlSidePanel.BackColor = Color.Wheat;
            pnlSidePanel.Location = new Point(0, 387);
            pnlSidePanel.Size = new Size(7, btnSettings.Height);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            pnlSidePanel.BackColor = Color.Wheat;
            pnlSidePanel.Location = new Point(0,443);
            pnlSidePanel.Size = new Size(7,btnExit.Height);
            if (MessageBox.Show("Do you want o exit the system?\nSave all your information before its lost. Unsaved work will be lost", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userStudentDetails1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            userNewStudentt.Visible = true;
            userNewStudentt.BringToFront();
            userStudentDetailss.Visible = false;
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            userStudentDetailss.Visible = true;
            userStudentDetailss.BringToFront();
            userNewStudentt.Visible = false;
            
        }
    }
}
