﻿namespace _101Shop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int CakeId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Cake Cake { get; set; }
        public virtual Order Order { get; set; }
    }
}
