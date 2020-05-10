using _101Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.ViewModels
{
    public class CakeListViewModel
    {
        public IEnumerable<Cake> cakes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
