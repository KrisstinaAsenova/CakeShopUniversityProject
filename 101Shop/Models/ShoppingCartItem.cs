using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Models
{
    public class ShoppingCartItem
    {
        public Cake Cake { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
