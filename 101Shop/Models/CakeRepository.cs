using _101Shop.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public Cake Create(string name, string shortDesc, string longDesc, decimal price)
        {
            var cake = new Cake() { Name = name, ShortDescription = shortDesc, LongDescription = longDesc, Price = price };
            _appDbContext.Cakes.Add(cake);
            _appDbContext.SaveChanges();
            return cake;
        }

        public Cake GetcakeById(int cakeId)
        {
            var cake = _appDbContext.Cakes.FirstOrDefault(cake => cake.CakeId == cakeId);
            return cake;
        }

        public ICollection<Cake> GetAllCakes()
        {
            var cakes= _appDbContext.Cakes.ToList();
            
            
            return cakes;
        }
    }
}
