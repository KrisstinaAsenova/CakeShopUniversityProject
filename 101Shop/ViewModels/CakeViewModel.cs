using _101Shop.Models;
using System.Collections.Generic;

namespace _101Shop.ViewModels
{
    public class CakeViewModel
    {
        public int CakeId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSpecial { get; set; }
        public List<Comment> Comments { get; set; }
        public string Text { get; set; }
    }
}
