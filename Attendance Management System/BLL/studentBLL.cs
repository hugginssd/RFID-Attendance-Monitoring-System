using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.BLL
{
    class studentBLL
    {
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Class { get; set; }
        public DateTime RegDate { get; set; }
    }
}
