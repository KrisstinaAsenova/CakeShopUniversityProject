﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _101Shop.Models
{
    public class Cake
    {
        public int CakeId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSpecial { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
