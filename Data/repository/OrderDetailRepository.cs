using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using Microsoft.EntityFrameworkCore;

namespace BookHaven.Data.repository
{
    public class OrderDetailRepository: IOrderDetailRepository
    {
        private readonly AppDbContext _context;
        public OrderDetailRepository(AppDbContext appDbContext) {
            _context = appDbContext;
        }

        public void Add(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public void Update(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
            _context.SaveChanges();
        }

        public void Delete(int orderDetailId)
        {
            var orderDetai = _context.OrderDetails.Find(orderDetailId);
            if (orderDetai != null)
            {
                _context.OrderDetails.Remove(orderDetai);
                _context.SaveChanges();
            }
        }

        public OrderDetail GetById(int orderDetailId) => _context.OrderDetails.Find(orderDetailId);

        public List<OrderDetail> GetAll() => _context.OrderDetails.ToList();

        public List<OrderDetail> GetOrderDetailByOrderId(int id)
        {
            return _context.OrderDetails
                           .Include(od => od.Book) // Include book details
                           .Where(od => od.OrderId == id)
                           .ToList();
        }

        public List<OrderDetail> GetOrderDetailByStockOrderId(int id)
        {
            return _context.OrderDetails
                           .Include(od => od.Book) // Include book details
                           .Where(od => od.StockOrderId == id)
                           .ToList();
        }

        public List<OrderDetail> SearchOrdDetail(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
