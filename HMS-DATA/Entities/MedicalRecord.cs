﻿using System;


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
