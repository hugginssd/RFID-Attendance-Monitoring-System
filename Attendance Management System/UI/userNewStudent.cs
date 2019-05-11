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
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            sbll.CandidateNo = txtPreviousCandidateNo.Text.ToUpper();
            sbll.Address = txtAddress1.Text.ToUpper();
            sbll.Address2 = txtAddress2.Text.ToUpper();
            sbll.DOB = dtpDOB.Value.Date;
           
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
