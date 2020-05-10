using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _101Shop.Models;
using _101Shop.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace _101Shop.Controllers
{
    [Route("api/[controller]")]
    public class CakeDataController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly AppDbContext _appDbContext;

        public CakeDataController(ICakeRepository cakeRepository, AppDbContext appDbContext)
        {
            _cakeRepository = cakeRepository;
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IEnumerable<CakeViewModel> LoadMorecakes()
        {
            IEnumerable<Cake> dbcakes = null;

            dbcakes = _cakeRepository.cakes.OrderBy(p => p.CakeId).Take(10);

            List<CakeViewModel> cakes = new List<CakeViewModel>();

            foreach (var dbcake in dbcakes)
            {
                cakes.Add(MapDbcakeTocakeViewModel(dbcake));
            }
            return cakes;
        }

        private CakeViewModel MapDbcakeTocakeViewModel(Cake dbcake)
        {
            return new CakeViewModel()
            {
                CakeId = dbcake.CakeId,
                Name = dbcake.Name,
                Price = dbcake.Price,
                ShortDescription = dbcake.ShortDescription
            };
        }
        
    }
}
