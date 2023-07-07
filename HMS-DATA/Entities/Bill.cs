using System;
using System.ComponentModel.DataAnnotations;

namespace HMS_DATA.Entities
{
    public class Bill : BaseEntity
    {
        [Required]
        public string BillNumber { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
        public string InsuranceCompany { get; set; }
        public bool IsPaid { get; set; }
    }
}
