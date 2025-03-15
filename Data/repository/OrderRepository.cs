using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookHaven.Data.repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }


        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.Include(o => o.OrderDetails).FirstOrDefault(o => o.Id == id);
        }
        
        public List<Order> GetAll() => _context.Orders.ToList();

        public List<Order> SearchOrders(string key, DateTime? createdDate)
        {
            var query = _context.Orders.Include(o => o.Customer).AsQueryable();

            if (!string.IsNullOrEmpty(key))
                query = query.Where(o => o.Customer.Contact.Contains(key) || o.Status.Contains(key));

            if (createdDate.HasValue)
                query = query.Where(o => o.CreatedDate.Date == createdDate.Value.Date);

            //if (!string.IsNullOrEmpty(modifiedBy))
            //    query = query.Where(o => o.ModifiedUser.userName.Contains(modifiedBy));

            return query.ToList();
        }

        public Order GetByUid(String id)
        {
            return _context.Orders.FirstOrDefault(o => o.UniqueId == id);
        }
    }
}
