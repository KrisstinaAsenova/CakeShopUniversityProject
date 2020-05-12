using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;


        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //public void CreateOrder(Order order)
        //{
        //    order.OrderPlaced = DateTime.Now;

        //    _appDbContext.Orders.Add(order);

        //    var shoppingCartItems = _shoppingCart.ShoppingCartItems;

        //    foreach (var shoppingCartItem in shoppingCartItems)
        //    {
        //        var orderDetail = new OrderDetail()
        //        {
        //            Amount = shoppingCartItem.Amount,
        //            cakeId = shoppingCartItem.Cake.CakeId,
        //            OrderId = order.OrderId,
        //            Price = shoppingCartItem.Cake.Price
        //        };

        //        _appDbContext.OrderDetails.Add(orderDetail);
        //    }

        //    _appDbContext.SaveChanges();
        //}
    }
}
