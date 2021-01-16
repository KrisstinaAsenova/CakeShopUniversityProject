using _101Shop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace _101Shop.Models
{
    public class CakeRepository: ICakeRepository
    {
        private readonly AppDbContext _appDbContext;
        public CakeRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Cake> cakes
        {
            get
            {
                return _appDbContext.Cakes;
            }
        }

        public Cake Create(string name, string shortDesc, string longDesc, decimal price, string allergyInformation, string imageURL, bool isSpecial)
        {
            var cake = new Cake()
            {
                Name = name,
                ShortDescription = shortDesc,
                LongDescription = longDesc,
                Price = price,
                AllergyInformation = allergyInformation,
                ImageUrl = imageURL,
                IsSpecial = isSpecial,
                Comments = new List<Comment>()
            };
            _appDbContext.Cakes.Add(cake);
            _appDbContext.SaveChanges();
            return cake;
        }

        public Cake GetcakeById(int cakeId)
        {
            var cake = _appDbContext.Cakes.FirstOrDefault(cake => cake.CakeId == cakeId);
            var comments = _appDbContext.Comments.Where(c => c.CakeId == cakeId).ToList();   

            cake.Comments = comments;
            return cake;
        }

        public ICollection<Cake> GetAllCakes()
        {
            var cakes = _appDbContext.Cakes.Where(x => !x.IsSpecial).ToList();
            return cakes;
        }
        public ICollection<Cake> GetAllSpecialCakes()
        {
            var specialCakes = _appDbContext.Cakes.Where(x => x.IsSpecial).ToList();
            return specialCakes;
        }

        public void RemoveCake(int cakeId)
        {
            var removeCake = _appDbContext.Cakes.FirstOrDefault(x => x.CakeId == cakeId);
            _appDbContext.Cakes.Remove(removeCake);
            _appDbContext.SaveChanges();
        }

        public void EditCake(CakeViewModel cake) {
            var cakeToEdit = GetcakeById(cake.CakeId);
            cakeToEdit.Name = cake.Name;
            cakeToEdit.ShortDescription = cake.ShortDescription;
            cakeToEdit.LongDescription = cake.LongDescription;
            cakeToEdit.Price = cake.Price;
            cakeToEdit.AllergyInformation = cake.AllergyInformation;
            cakeToEdit.ImageUrl = cake.ImageUrl;
            cakeToEdit.IsSpecial = cake.IsSpecial;

            _appDbContext.SaveChanges();
        }

        public Comment AddComment(Comment comment)
        {
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();
            return comment;
        }

        public Comment GetComments(Comment comment)
        {
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();
            return comment;
        }
    }
}
