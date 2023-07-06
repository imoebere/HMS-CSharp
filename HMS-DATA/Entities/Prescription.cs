using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class Prescription : BaseEntity
    {
        public int PatientID { get; set; } 
        public Patient Patient { get; set; } 
        public int DoctorID { get; set; } 
        public Doctor Doctor { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string Medications { get; set; }
        public string Dosage { get; set; }
        public string Instructions { get; set; }
    }
}
