using System;
using System.Collections.Generic;
using System.Text;
using _101Shop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _101Shop.Data
{
    public class CakeShopContext : IdentityDbContext<User>
    {
        public CakeShopContext(DbContextOptions<CakeShopContext> options)
            : base(options)
        {
        }
    }
}
