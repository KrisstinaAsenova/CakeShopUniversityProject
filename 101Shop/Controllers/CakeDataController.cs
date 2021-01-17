using _101Shop.Data;
using _101Shop.Models;
using _101Shop.Services.Contracts;
using _101Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<CakeViewModel>> LoadMorecakes()
        {
            IEnumerable<Cake> dbcakes = null;

            dbcakes = await Task.Run(() => _cakeRepository.cakes.OrderBy(p => p.CakeId).Take(10));

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
