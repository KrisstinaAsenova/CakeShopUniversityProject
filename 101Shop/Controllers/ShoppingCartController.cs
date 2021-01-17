using _101Shop.Services;
using _101Shop.Services.Contracts;
using _101Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<ViewResult> Index()
        {
            var items = await Task.Run(() => _shoppingCart.GetShoppingCartItems());
            await Task.Run(() => _shoppingCart.ShoppingCartItems = items);

            var shoppingCardTot = await Task.Run(() => _shoppingCart.GetShoppingCartTotal());
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = shoppingCardTot
            };

            return View(shoppingCartViewModel);
        }

        public async Task<RedirectToActionResult> AddToShoppingCart(int cakeId)
        {
            var cake = await Task.Run(() => _cakeRepository.cakes.FirstOrDefault(p => p.CakeId == cakeId));

            await Task.Run(() => _shoppingCart.AddToCart(cake, 1));

            if (cake.IsSpecial)
            {
                return RedirectToAction("Specials", "Cake");
            }
            else
            {
                return RedirectToAction("List", "Cake");
            }
        }

        public async Task<RedirectToActionResult> RemoveFromShoppingCart(int cakeId)
        {
            var selectedcake = await Task.Run(() =>  _cakeRepository.cakes.FirstOrDefault(p => p.CakeId == cakeId));

            if (selectedcake != null)
            {
                await Task.Run(() => _shoppingCart.RemoveFromCart(selectedcake));
            }

            return RedirectToAction("Index");
        }
    }
}
