using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.entity
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }  // Many-to-One relation with Customer

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public string Status { get; set; }  // Enum or string (e.g., "InStoreCompleted", "ToDeliver", etc.)

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User ModifiedUser { get; set; }  // Many-to-One relation with User

        public List<OrderDetail> OrderDetails { get; set; }  // One-to-Many relation with OrderDetails

        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string UniqueId { get; set; }
    }
}
