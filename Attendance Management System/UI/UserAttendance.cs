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
    public partial class UserAttendance : UserControl
    {
        public UserAttendance()
        {
            InitializeComponent();
        }

        private void BtnBulkActions_Click(object sender, EventArgs e)
        {
            BtnBulkActions.ForeColor = Color.White;
            BtnBulkActions.BackColor = Color.FromArgb(0, 122, 204);
            BtnCheckedIn.ForeColor = Color.Gray;
            BtnCheckedIn.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnUnConfirmed.ForeColor = Color.Gray;
            BtnUnConfirmed.BackColor = Color.White;
            BtnAbsent.ForeColor = Color.Gray;
            BtnAbsent.BackColor = Color.White;
        }

        private void BtnAbsent_Click(object sender, EventArgs e)
        {
            BtnAbsent.ForeColor = Color.White;
            BtnAbsent.BackColor = Color.FromArgb(0, 122, 204);
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnCheckedIn.ForeColor = Color.Gray;
            BtnCheckedIn.BackColor = Color.White;
            BtnUnConfirmed.ForeColor = Color.Gray;
            BtnUnConfirmed.BackColor = Color.White;
        }

        private void BtnCheckedOut_Click(object sender, EventArgs e)
        {
            BtnCheckedOut.ForeColor = Color.White;
            BtnCheckedOut.BackColor = Color.FromArgb(0, 122, 204);
            BtnAbsent.ForeColor = Color.Gray;
            BtnAbsent.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnCheckedIn.ForeColor = Color.Gray;
            BtnCheckedIn.BackColor = Color.White;
            BtnUnConfirmed.ForeColor = Color.Gray;
            BtnUnConfirmed.BackColor = Color.White;
        }

        private void BtnCheckedIn_Click(object sender, EventArgs e)
        {

            BtnCheckedIn.ForeColor = Color.White;
            BtnCheckedIn.BackColor = Color.FromArgb(0, 122, 204);
            BtnUnConfirmed.ForeColor = Color.Gray;
            BtnUnConfirmed.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnAbsent.ForeColor = Color.Gray;
            BtnAbsent.BackColor = Color.White;
        }

        private void BtnUnConfirmed_Click(object sender, EventArgs e)
        {
            BtnUnConfirmed.ForeColor = Color.White;
            BtnUnConfirmed.BackColor = Color.FromArgb(0, 122, 204);
            BtnCheckedIn.ForeColor = Color.Gray;
            BtnCheckedIn.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnAbsent.ForeColor = Color.Gray;
            BtnAbsent.BackColor = Color.White;
        }
    }
}
