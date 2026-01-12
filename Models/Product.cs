using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // Define
namespace Clothify.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public int CollectionID { get; set; }

        [Required]
        public int FabricTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string SKU { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        [Required]
        [StringLength(50)]
        public string DesignCode { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal ShirtLength { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal? DupattaLength { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [Required]
        public bool IsAvailable { get; set; } = true;

        [Required]
        [StringLength(500)]
        public string MainImageURL { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public Category Category { get; set; }
        public Collection Collection { get; set; }
        public FabricType FabricType { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
