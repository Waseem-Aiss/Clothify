using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Clothify.Models
{
    public class ProductImage
    {
        [Key]
        public int ProductImageID { get; set; }

        [Required]
        public int ProductID { get; set; }  // FK to Product

        [Required]
        [StringLength(500)]
        public string ImageURL { get; set; }  // Image path / URL

        [Required]
        public bool IsPrimary { get; set; } = false;  // Marks main image

        // Navigation property
        public Product Product { get; set; }
    }
}
