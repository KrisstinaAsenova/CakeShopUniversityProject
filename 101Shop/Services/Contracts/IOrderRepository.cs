using _101Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Services.Contracts
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        ICollection<OrderDetail> GetAllOrders();
        ICollection<Order> GetAllOrdersForDelivery();
    }
}
