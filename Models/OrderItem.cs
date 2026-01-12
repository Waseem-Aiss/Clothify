using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothify.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        [Required]
        public int OrderID { get; set; }  // FK to Order

        [Required]
        public int ProductID { get; set; }  // FK to Product

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        // Navigation properties
        public Order Order { get; set; }       // One-to-many: Order → OrderItems
        public Product Product { get; set; }   // One-to-many: Product → OrderItems
    }
}
