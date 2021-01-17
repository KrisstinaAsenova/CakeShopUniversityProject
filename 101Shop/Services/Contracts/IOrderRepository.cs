using _101Shop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _101Shop.Services.Contracts
{
    public interface IOrderRepository
    {
        Task CreateOrder(Order order);
        Task<ICollection<OrderDetail>> GetAllOrders();
        Task<ICollection<Order>> GetAllOrdersForDelivery();
    }
}
