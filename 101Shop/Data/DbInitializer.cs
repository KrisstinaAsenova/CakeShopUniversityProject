using _101Shop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Data
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "771f568e-a7d5-496b-90c4-72ff997368e6", Name = "Admin", NormalizedName = "ADMIN" },
               new IdentityRole { Id = "93c66dd9-11c5-4836-b104-a9c333549530", Name = "Cook", NormalizedName = "COOK" },
               new IdentityRole { Id = "a7b8a4da-39e4-463c-abf1-4fd486b1876d", Name = "Delivery", NormalizedName = "DELIVERY" }
           );

            var hasher = new PasswordHasher<User>();

            User admin = new User { Id = "fe86f129-41f3-4ab8-a61c-5f47239a1393", UserName = "admin", NormalizedUserName = "ADMIN", Email = "admin@gmail.com", NormalizedEmail = "ADMIN@GMAIL.COM", LockoutEnabled = true };
            admin.PasswordHash = hasher.HashPassword(admin, "admin123");

            User cook = new User { Id = "565dfbc0-2681-4f29-bc97-a619eacf339c", UserName = "cook", NormalizedUserName = "COOK", Email = "cook@gmail.com", NormalizedEmail = "COOK@GMAIL.COM", LockoutEnabled = true };
            cook.PasswordHash = hasher.HashPassword(cook, "cook123");

            User delivery = new User { Id = "a4fe24ba-7c36-4069-a56c-6dac415b26ef", UserName = "delivery", NormalizedUserName = "DELIVERY", Email = "delivery@gmail.com", NormalizedEmail = "DELIVERY@GMAIL.COM", LockoutEnabled = true };
            delivery.PasswordHash = hasher.HashPassword(delivery, "delivery123");

            builder.Entity<User>().HasData(admin, cook, delivery);


            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "771f568e-a7d5-496b-90c4-72ff997368e6",
                    UserId = admin.Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = "93c66dd9-11c5-4836-b104-a9c333549530",
                    UserId = cook.Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b8a4da-39e4-463c-abf1-4fd486b1876d",
                    UserId = delivery.Id
                });

            //var category1 = new Category { CategoryId = 114, CategoryName = "Fruit cakes", Description = "All-fruity cakes" };
            //var category2 = new Category { CategoryId = 112, CategoryName = "Cheese cakes", Description = "Cheesy all the way" };
            //var category3 = new Category { CategoryId = 113, CategoryName = "Seasonal cakes", Description = "Get in the mood for a seasonal cake" };

            //builder.Entity<Category>().HasData(category1, category2, category3);



            var cake1 = new Cake
            {
                CakeId = 1,
                Name = "Apple Cake",
                Price = 12.95M,
                ShortDescription = "Our famous apple cakes!",
                LongDescription = "Icing carrot cake mies.",
                AllergyInformation = "nqma",
                ImageUrl = "/images/tikva.jpg",
            };

            var comment = new Comment
            {
                CakeId = 1,
                UserName = "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                Text = "test123",
                CommentId = 1
            };
            builder.Entity<Comment>().HasData(comment);
            //cake1.Comments = test;

            var cake2 = new Cake
            {
                CakeId = 2,
                Name = "Blueberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription = "Icing carrot e gummies.",
                AllergyInformation = "ima",
                ImageUrl = "/images/shokolad.jpg"
            };

            var cake3 = new Cake
            {
                CakeId = 3,
                Name = "Cheese Cake",
                Price = 18.95M,
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                LongDescription = "Icinake dragée gummies.",
                AllergyInformation = "..malko",
                ImageUrl = "/images/tikva.jpg"
            };

            var cake4 = new Cake
            {
                CakeId = 4,
                Name = "Cheese Cake",
                Price = 28.95M,
                ShortDescription = "Plain cheese cacasdasdke. Plain pleasure.",
                LongDescription = "Icinake dasdadragée gummies.",
                AllergyInformation = "..maasdadlko",
                ImageUrl = "/images/shokolad.jpg"
            };

            builder.Entity<Cake>().HasData(cake1, cake2, cake3, cake4);

            var user = new User { Id = "123" };
            builder.Entity<User>().HasData(user);


        }
    }
}

