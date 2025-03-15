using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using BookHaven.Data.repository;

namespace BookHaven.Business.services
{
    public class StockOrderService
    {
        private readonly IStockOrderRepository _stockOrderRepository;

        public StockOrderService(IStockOrderRepository stockOrderRepository)
        {
            _stockOrderRepository = stockOrderRepository;
        }

        public void AddStockOrder(StockOrder stockOrder) => _stockOrderRepository.AddStockOrder(stockOrder);

        public void UpdateStockOrder(StockOrder stockOrder) => _stockOrderRepository.UpdateStockOrder(stockOrder);

        public StockOrder GetStockOrderById(int id) => _stockOrderRepository.GetStockOrderById(id);
        public StockOrder GetByUid(String id) => _stockOrderRepository.GetByUid(id);

        public List<StockOrder> GetAllStockOrders() => _stockOrderRepository.GetAllStockOrders();

    }
}
