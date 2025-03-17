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
        Order AddOrder(Order order);
        void UpdateOrder(Order order);
        Order GetOrderById(int id);
        List<Order> SearchOrders(string key, DateTime? createdDate);

        Order GetByUid(String id);
        List<Order> GetAll();

        List<Order> GetByDateRange(DateTime startDate, DateTime endDate);

        List<Order> GetByCustomerId(int customerId);

        List<Order> GetByStatus(string status);
        string GetNewOrderNumber();
        void Delete(int id);
        List<Order> GetTopSellingItems(DateTime startDate, DateTime endDate, int count);
    }
}
