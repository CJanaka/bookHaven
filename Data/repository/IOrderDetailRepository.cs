using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;

namespace BookHaven.Data.repository
{
    public interface IOrderDetailRepository
    {
        void Add(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(int orderDetailId);
        OrderDetail GetById(int orderDetailId);
        List<OrderDetail> GetAll();
        List<OrderDetail> SearchOrdDetail(string keyword);

        List<OrderDetail> GetOrderDetailByStockOrderId(int id);
        List<OrderDetail> GetOrderDetailByOrderId(int id);
    }
}
