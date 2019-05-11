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
using iTextSharp.text.xml;

namespace Attendance_Management_System.UI
{
    public partial class userNewStudent : UserControl
    {
        public userNewStudent()
        {
            InitializeComponent();
        }
        StudentBLL sbll = new StudentBLL();
        StudentDAL sdal = new StudentDAL();
        OpenFileDialog opdg = new OpenFileDialog();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                sbll.CandidateNo = txtPreviousCandidateNo.Text.ToUpper();
                sbll.Address = txtAddress1.Text.ToUpper();
                sbll.Address2 = txtAddress2.Text.ToUpper();
                sbll.DOB = dtpDOB.Value.Date;
                sbll.StudentID = Convert.ToInt32(txtStudentID.Text);
                sbll.FirstName = txtFirstName.Text.ToUpper();
                sbll.LastName = txtLastName.Text.ToUpper();
                sbll.Email = "student@gmail.com";
                sbll.Picture = System.IO.File.ReadAllBytes(opdg.FileName);
                sbll.Gender = Convert.ToChar(CmbGender.Text.Remove(0, 1));
                sbll.NoOfSubjects = NuDNumberOfSubjects.Value;
                sbll.SchoolAddress = TxtSchoolAddress.Text.ToUpper();
                bool IsSuccess = sdal.Insert(sbll);
                if (IsSuccess)
                {
                    MessageBox.Show("Successfully created");
                }
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

        private void lblBrowse_Click(object sender, EventArgs e)
        {
            string piclocation = "";
            opdg.Filter = null;
            piclocation = opdg.FileName;
            opdg.ShowDialog();

        }
        void Reset()
        {

        }
    }
}
