using HMS_DATA.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DATA.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Address { get; set; }
        public string? PublicId { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime DateRegisted { get; set; } 
        public DateTime DateUpdated { get; set; }
    }
}
