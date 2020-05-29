﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string AddressLine { get; set; }
        public string PhoneNumber { get; set; }
        public decimal OrderTotal { get; set; }

    }
}
