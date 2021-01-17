using _101Shop.Models;
using System.Collections.Generic;

namespace _101Shop.ViewModels
{
    public class CakeListViewModel
    {
        public IEnumerable<Cake> cakes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
