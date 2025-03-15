using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookHaven.Data.repository
{
    public class StockOrderRepository : IStockOrderRepository
    {
        private readonly AppDbContext _context;

        public StockOrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddStockOrder(StockOrder stockOrder)
        {
            _context.StockOrders.Add(stockOrder);
            _context.SaveChanges();
        }

        public void UpdateStockOrder(StockOrder stockOrder)
        {
            _context.StockOrders.Update(stockOrder);
            _context.SaveChanges();
        }

        public StockOrder GetStockOrderById(int id)
        {
            return _context.StockOrders.Find(id);
        } 
        
        public StockOrder GetByUid(String id)
        {
            return _context.StockOrders.FirstOrDefault(o => o.UniqueId == id);
        }

        public List<StockOrder> GetAllStockOrders()
        {
            return _context.StockOrders.ToList();
        }
    }
}
