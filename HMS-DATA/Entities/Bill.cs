using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class Bill : BaseEntity
    {
        public string BillNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string InsuranceCompany { get; set; }
        public bool IsPaid { get; set; }
    }
}
