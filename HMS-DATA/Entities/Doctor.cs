using HMS_DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string UserId { get; set; } 
        public ApplicationUser User { get; set; } 
        public string Specialization { get; set; }
        public int Experience { get; set; }
        public Department Department { get; set; }
    }
}
