﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.BLL
{
    class UserBLL
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int CreatedBy { get; set; }
        public int Active { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
