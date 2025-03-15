using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;

namespace BookHaven.Data.repository
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        Order GetOrderById(int id);
        List<Order> SearchOrders(string key, DateTime? createdDate);

        Order GetByUid(String id);
        List<Order> GetAll();
    }
}
