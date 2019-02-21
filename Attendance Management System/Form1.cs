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
           // this.Size = new Size(1300, 600);
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
        }

        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            btnNewStudent.Visible = true;
            pnlSidePanel.Location = new Point(0, 228);
            pnlSidePanel.Size = new Size(7, btnStudentDetails.Height);
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
