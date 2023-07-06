using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class BaseEntity
    {
     
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       [Key]
       public string Id { get; set; }
       public DateTime DateCreated { get; set; }
       public DateTime? DateUpdated { get; set; }
       public bool IsDeleted { get; set; }
        
    }
}
