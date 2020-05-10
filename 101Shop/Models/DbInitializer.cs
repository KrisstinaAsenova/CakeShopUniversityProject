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

            //var category1 = new Category { CategoryId = 114, CategoryName = "Fruit cakes", Description = "All-fruity cakes" };
            //var category2 = new Category { CategoryId = 112, CategoryName = "Cheese cakes", Description = "Cheesy all the way" };
            //var category3 = new Category { CategoryId = 113, CategoryName = "Seasonal cakes", Description = "Get in the mood for a seasonal cake" };

            //builder.Entity<Category>().HasData(category1, category2, category3);

            var cake1 = new Cake { CakeId = 1, Name = "Apple Cake", Price = 12.95M, 
                ShortDescription = "Our famous apple cakes!", LongDescription = "Icing carrot cake mies.",
                AllergyInformation = "nqma", ImageUrl= "/images/tikva.jpg", InStock = true };

            var cake2 = new Cake { CakeId = 2, Name = "Blueberry Cheese Cake", Price = 18.95M,
                ShortDescription = "You'll love it!", LongDescription = "Icing carrot e gummies.",
                AllergyInformation = "ima", ImageUrl = "/images/shokolad.jpg", InStock = true };
            
            var cake3 = new Cake { CakeId = 3, Name = "Cheese Cake", Price = 18.95M,
                ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "Icinake dragée gummies.",
                AllergyInformation = "..malko", ImageUrl = "/images/tikva.jpg", InStock = true };
            
            var cake4 = new Cake { CakeId = 4, Name = "Cheese Cake", Price = 28.95M, 
                ShortDescription = "Plain cheese cacasdasdke. Plain pleasure.", LongDescription = "Icinake dasdadragée gummies.",
                AllergyInformation = "..maasdadlko", ImageUrl = "/images/shokolad.jpg", InStock = true };

            builder.Entity<Cake>().HasData(cake1, cake2, cake3, cake4);

            var user = new User { Id = "123", Type = "Admin" };
            builder.Entity<User>().HasData(user);


        }
    }
}

