using HMS_DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class Nurse : BaseEntity
    {
        public string UserId { get; set; } 
        public ApplicationUser User { get; set; }
        public int PatientID { get; set; } 
        public Patient Patient { get; set; } 
        public int Experience { get; set; }
        public Department Department { get; set; }
    }
}
