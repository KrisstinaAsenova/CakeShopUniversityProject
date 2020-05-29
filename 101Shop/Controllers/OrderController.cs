using _101Shop.Models;
using _101Shop.ViewModels;
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


        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some pies first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult ListOrders()
        {
            var orders = _orderRepository.GetAllOrders();
            var test = orders.Select(order => new OrderDetailViewModel
            {
                CakeId = order.CakeId,
                OrderId = order.OrderId,
                Amout =order.Amount
            });

            return View(test);
        }

        [HttpGet]
        public IActionResult ListOrdersForDelivery()
        {
            var orders = _orderRepository.GetAllOrdersForDelivery();
            var test = orders.Select(order => new OrderViewModel
            {
                OrderId = order.OrderId,
                FirstName = order.FirstName,
                AddressLine = order.AddressLine,
                PhoneNumber = order.PhoneNumber,
                OrderTotal = order.OrderTotal
            });

            return View(test);
        }
    }
}
