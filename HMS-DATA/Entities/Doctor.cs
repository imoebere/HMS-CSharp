using HMS_DATA.Enum;
using System;


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
