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

        public Order PlaceOrder(Order order)
        {
            return _orderRepository.AddOrder(order);
        }        

        public void addOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailRepository.Add(orderDetail);
        }

        public void updateOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailRepository.Update(orderDetail);
        }
        
        public void deleteOrderDetail(int orderDetailId)
        {
            _orderDetailRepository.Delete(orderDetailId);
        }

        public void updateOrder(Order order)
        {
            _orderRepository.UpdateOrder(order);
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
        public Order GetById(int id) => _orderRepository.GetOrderById(id);

        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return _orderRepository.GetByDateRange(startDate, endDate);
        }
    }
}
