using _101Shop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Controllers
{
    public class OrderController: Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }


        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }


        public IActionResult CheckoutComplete(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            _shoppingCart.ClearCart();
            
            return View(order);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Order order)
        {
           
            return View(order);
        }
    }
}
