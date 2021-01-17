using _101Shop.Models;
using System.Collections.Generic;

namespace _101Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cake> cakesOfTheWeek { get; set; }
    }
}
