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

        public Order AddOrder(Order order)
        {
             _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
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

        public List<Order> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            //return _context.Orders
            //    .Include(o => o.Customer)
            //    .Include(o => o.ModifiedUser)
            //    .Include(o => o.OrderDetails.Select(od => od.Book))
            //    .Where(o => o.CreatedDate >= startDate && o.CreatedDate <= endDate)
            //    .ToList();

            return _context.Orders
                .Where(o => o.CreatedDate >= startDate && o.CreatedDate <= endDate)
                .Include(o => o.OrderDetails)  // Include OrderDetails first
                    .ThenInclude(od => od.Book)
                .Include(o => o.Customer)
                .Include(o => o.ModifiedUser)
                .ToList();

        }

        public List<Order> GetByCustomerId(int customerId)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.ModifiedUser)
                .Include(o => o.OrderDetails)
                .Where(o => o.CustomerId == customerId)
                .ToList();
        }

        public List<Order> GetByStatus(string status)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.ModifiedUser)
                .Include(o => o.OrderDetails)
                .Where(o => o.Status == status)
                .ToList();
        }

        public string GetNewOrderNumber()
        {
            // Generate a unique order number based on date and sequence
            string datePrefix = DateTime.Now.ToString("yyyyMMdd");

            // Get the last order number with today's prefix
            var lastOrder = _context.Orders
                .Where(o => o.UniqueId.StartsWith(datePrefix))
                .OrderByDescending(o => o.UniqueId)
                .FirstOrDefault();

            int sequence = 1;
            if (lastOrder != null)
            {
                // Extract the sequence number from the last order and increment
                string sequencePart = lastOrder.UniqueId.Substring(datePrefix.Length);
                if (int.TryParse(sequencePart, out int lastSequence))
                {
                    sequence = lastSequence + 1;
                }
            }

            // Format: YYYYMMDD####
            return $"{datePrefix}{sequence:D4}";
        }



        public void Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public List<Order> GetTopSellingItems(DateTime startDate, DateTime endDate, int count)
        {
            return _context.Orders
                .Include(o => o.OrderDetails.Select(od => od.Book))
                .Where(o => o.CreatedDate >= startDate && o.CreatedDate <= endDate)
                .ToList();
        }
    }
}
