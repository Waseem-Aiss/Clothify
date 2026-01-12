using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clothify.Models
{
    public class FabricType
    {
       
            [Key]
            public int FabricTypeID { get; set; }

            [Required]
            [StringLength(50)]
            public string FabricName { get; set; }

            [Required]
            public bool IsActive { get; set; } = true;

            // Navigation property
            public ICollection<Product> Products { get; set; }

        }
    
}
