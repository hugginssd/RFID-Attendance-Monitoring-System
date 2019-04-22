using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.UI
{
    public partial class UserStudentMasterDetails : UserControl
    {
        public UserStudentMasterDetails()
        {
            InitializeComponent();
        }

        private void UserStudentMasterDetails_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
