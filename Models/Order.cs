using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Clothify.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public string CustomerID { get; set; }  // FK to ApplicationUser (AspNetUsers)

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        [StringLength(20)]
        public string PaymentStatus { get; set; }  // Pending, Paid, COD

        [Required]
        [StringLength(20)]
        public string ShippingStatus { get; set; } // Processing, Shipped, Delivered

        [Required]
        [StringLength(30)]
        public string OrderStatus { get; set; } // Pending, Confirmed, Cancelled

        // Navigation properties
        public ApplicationUser Customer { get; set; }  // One-to-many: Customer → Orders
        public ICollection<OrderItem> OrderItems { get; set; }  // One-to-many: Order → OrderItems

    }
}
