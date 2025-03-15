using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using BookHaven.Data.repository;

namespace BookHaven.Business.services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderService(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
        }

        public void PlaceOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }        

        public void addOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailRepository.Add(orderDetail);
        }

        public List<OrderDetail> GetOrderDetailByOrderId(int id)
        {
            return _orderDetailRepository.GetOrderDetailByOrderId(id);
        }        
        
        public OrderDetail GetOrderDetailByOrderDetailId(int id)
        {
            return _orderDetailRepository.GetById(id);
        }
        
        public List<OrderDetail> GetOrderDetailByStockOrderId(int id)
        {
            return _orderDetailRepository.GetOrderDetailByStockOrderId(id);
        }
        
        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public void UpdateOrderStatus(int orderId, string status)
        {
            var order = _orderRepository.GetOrderById(orderId);
            if (order != null)
            {
                order.Status = status;
                order.ModifiedDate = DateTime.Now;
                _orderRepository.UpdateOrder(order);
            }
        }

        public List<Order> SearchOrders(string key, DateTime? createdDate)
        {
            return _orderRepository.SearchOrders(key, createdDate);
        }

        public Order GetByUid(String id) => _orderRepository.GetByUid(id);

    }
}
