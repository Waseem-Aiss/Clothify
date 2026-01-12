using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Clothify.Models
{
    public class Collection
    {
        [Key]
        public int CollectionID { get; set; }  // Primary Key

        [Required]
        [StringLength(100)]
        public string CollectionName { get; set; }  // Name of the collection

        [Required]
        public DateTime LaunchDate { get; set; }  // When collection launches

        [Required]
        public bool IsActive { get; set; } = true;  // Show/hide collection

        [Required]
        public int DisplayOrder { get; set; } = 0;  // Ordering on homepage

        // Navigation Property
        public ICollection<Product> Products { get; set; }  // One-to-Many

    }
}
