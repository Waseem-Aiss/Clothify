using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Clothify.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }  // Customer's first name

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }   // Customer's last name

        public string ShippingAddress { get; set; }  // Full address

        // Navigation property
        public ICollection<Order> Orders { get; set; }  // One-to-many: Customer → Orders
    }
}
