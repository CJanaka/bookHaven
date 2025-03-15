using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;

namespace BookHaven.Data.repository
{
    public interface IStockOrderRepository
    {
        void AddStockOrder(StockOrder stockOrder);
        void UpdateStockOrder(StockOrder stockOrder);
        StockOrder GetStockOrderById(int id);
        StockOrder GetByUid(String id);
        List<StockOrder> GetAllStockOrders();
    }
}
