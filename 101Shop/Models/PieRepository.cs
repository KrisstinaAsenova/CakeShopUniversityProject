using _101Shop.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Models
{
    public class PieRepository: IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> Pies
        {
            get
            {
                return _appDbContext.Pies;
            }
        }


        public Pie Create(string name, string shortDesc, string longDesc, decimal price)
        {
            var pie = new Pie() { Name = name, ShortDescription = shortDesc, LongDescription = longDesc, Price = price };
            _appDbContext.Pies.Add(pie);
            _appDbContext.SaveChanges();
            return pie;
        }

        public Pie GetPieById(int pieId)
        {
            var pie = _appDbContext.Pies.FirstOrDefault(pie => pie.PieId == pieId);
            return pie;
        }

        public ICollection<Pie> GetAllPies()
        {
            var pies= _appDbContext.Pies.ToList();
            
            
            return pies;
        }
    }
}
