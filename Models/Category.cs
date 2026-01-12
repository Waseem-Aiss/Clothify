using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Clothify.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        // Navigation property
        public ICollection<Product> Products { get; set; }
    }
}
