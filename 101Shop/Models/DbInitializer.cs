using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Models
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder builder)
        {

            //var category1 = new Category { CategoryId = 114, CategoryName = "Fruit pies", Description = "All-fruity pies" };
            //var category2 = new Category { CategoryId = 112, CategoryName = "Cheese cakes", Description = "Cheesy all the way" };
            //var category3 = new Category { CategoryId = 113, CategoryName = "Seasonal pies", Description = "Get in the mood for a seasonal pie" };

            //builder.Entity<Category>().HasData(category1, category2, category3);

            var pie1 = new Pie { PieId = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Icing carrot cake mies.", AllergyInformation = "nqma", InStock = true };
            var pie2 = new Pie { PieId = 2, Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "Icing carrot e gummies.", AllergyInformation = "ima", InStock = true };
            var pie3 = new Pie { PieId = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "Icinake dragée gummies.", AllergyInformation = "..malko", InStock = true };
            var pie4 = new Pie { PieId = 4, Name = "Cheese Cake", Price = 28.95M, ShortDescription = "Plain cheese cacasdasdke. Plain pleasure.", LongDescription = "Icinake dasdadragée gummies.", AllergyInformation = "..maasdadlko", InStock = true };

            builder.Entity<Pie>().HasData(pie1, pie2, pie3, pie4);

            var user = new User { Id = "123", Type = "Admin" };
            builder.Entity<User>().HasData(user);


        }
    }
}

