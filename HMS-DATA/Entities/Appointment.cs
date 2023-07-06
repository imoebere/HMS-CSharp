using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class Appointment : BaseEntity
    {
        public int PatientID { get; set; }
        public Patient Patient { get; set; } 
        public int DoctorID { get; set; } 
        public Doctor Doctor { get; set; }
        public string Purpose { get; set; }
        public AppointmentStatus Status { get; set; }
    }

}
