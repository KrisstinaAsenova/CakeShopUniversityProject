using _101Shop.Data;
using _101Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Services
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            var context = services.GetService<AppDbContext>();
            return new ShoppingCart(context);
        }

        public async Task AddToCart(Cake cake, int amount)
        {
            var shoppingCartItem =
                   await Task.Run(() => _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Cake.CakeId == cake.CakeId && s.ShoppingCartId == ShoppingCartId));

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Cake = cake,
                    Amount = 1
                };

                await Task.Run(() => _appDbContext.ShoppingCartItems.Add(shoppingCartItem));
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            await Task.Run(() => _appDbContext.SaveChanges());
        }

        public async Task<int> RemoveFromCart(Cake cake)
        {
            var shoppingCartItem =
                    await Task.Run(() => _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Cake.CakeId == cake.CakeId && s.ShoppingCartId == ShoppingCartId));

            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    await Task.Run(() => _appDbContext.ShoppingCartItems.Remove(shoppingCartItem));
                }
            }

            await Task.Run(() => _appDbContext.SaveChanges());
            return localAmount;
        }

        public async Task<List<ShoppingCartItem>> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       await Task.Run(() => _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Cake)
                           .ToList()));
        }

        public async Task ClearCart()
        {
            var cartItems = await Task.Run(() => _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId));

            await Task.Run(() => _appDbContext.ShoppingCartItems.RemoveRange(cartItems));
            await Task.Run(() => _appDbContext.SaveChanges());
        }


        public async Task<decimal> GetShoppingCartTotal()
        {
            return await Task.Run(() => _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Cake.Price * c.Amount).Sum());
        }
    }
}
