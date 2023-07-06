using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class Administrator : BaseEntity
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } 
        public string Role { get; set; }
    }
}
