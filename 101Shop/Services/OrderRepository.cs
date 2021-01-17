using _101Shop.Data;
using _101Shop.Models;
using _101Shop.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Services
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public async Task CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = await Task.Run(() => _shoppingCart.GetShoppingCartTotal());

            await Task.Run(() => _appDbContext.Orders.Add(order));
            await Task.Run(() => _appDbContext.SaveChanges());

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    CakeId = shoppingCartItem.Cake.CakeId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Cake.Price
                };

                await Task.Run(() => _appDbContext.OrderDetails.Add(orderDetail));
            }

            await Task.Run(() => _appDbContext.SaveChanges());
        }

        public async Task<ICollection<OrderDetail>> GetAllOrders()
        {
            return await Task.Run(() => _appDbContext.OrderDetails.ToList());
        }

        public async Task<ICollection<Order>> GetAllOrdersForDelivery()
        {
            return await Task.Run(() => _appDbContext.Orders.ToList());
        }
    }
}
