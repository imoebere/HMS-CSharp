using System;
using System.ComponentModel.DataAnnotations;

namespace HMS_DATA.Entities
{
    public class Patient : BaseEntity
    {
        public string UserId { get; set; } 
        public ApplicationUser User { get; set; } 
        [Required]
        public string MedicalHistory { get; set; }
        [Required]
        public string InsuranceDetails { get; set; }
        [Required]
        public string EmergencyContact { get; set; }
        [Required]
        public string Card_No { get; set; }
    }
}
