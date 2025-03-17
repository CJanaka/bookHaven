using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.dto
{
    public class SalesSummaryItem
    {
        public string Period { get; set; }
        public int TotalOrders { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal Discounts { get; set; }
        public decimal NetAmount { get; set; }
        public string TopSellingItem { get; set; }
    }
}
