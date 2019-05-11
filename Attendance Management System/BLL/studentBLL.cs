using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.BLL
{
    class StudentBLL
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int ClassID { get; set; }
        public  string Email { get; set; }
        public byte[] Picture { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string CandidateNo { get; set; }
        public decimal NoOfSubjects { get; set; }
        public string SchoolAddress { get; set; }
    }
}
