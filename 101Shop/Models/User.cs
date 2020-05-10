﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Models
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {
        public string Type { get; set; }
    }
}