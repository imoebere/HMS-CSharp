using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class MedicalRecord : BaseEntity
    {
        public int PatientID { get; set; } 
        public Patient Patient { get; set; } 
        public int DoctorID { get; set; } 
        public Doctor Doctor { get; set; } 
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
    }
}
