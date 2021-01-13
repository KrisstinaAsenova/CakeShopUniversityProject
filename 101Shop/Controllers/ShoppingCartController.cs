using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _101Shop.Models;
using _101Shop.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace _101Shop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICakeRepository cakeRepository, ShoppingCart shoppingCart)
        {
            _cakeRepository = cakeRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int cakeId)
        {
            var cake = _cakeRepository.cakes.FirstOrDefault(p => p.CakeId == cakeId);

            _shoppingCart.AddToCart(cake, 1);

            if (cake.IsSpecial)
            {
                return RedirectToAction("Specials", "Cake");
            }
            else
            {
                return RedirectToAction("List", "Cake");
            }
        }

        public RedirectToActionResult RemoveFromShoppingCart(int cakeId)
        {
            var selectedcake = _cakeRepository.cakes.FirstOrDefault(p => p.CakeId == cakeId);

            if (selectedcake != null)
            {
                _shoppingCart.RemoveFromCart(selectedcake);
            }
            return RedirectToAction("Index");
        }

    }
}
