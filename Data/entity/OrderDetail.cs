using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.entity
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order? Order { get; set; }  // Many-to-One relation with Order

        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }  // Many-to-One relation with Book

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public int? StockOrderId { get; set; }

        [ForeignKey("StockOrderId")]
        public StockOrder? StockOrder { get; set; }
    }
}
