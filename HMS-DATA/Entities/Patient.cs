using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
