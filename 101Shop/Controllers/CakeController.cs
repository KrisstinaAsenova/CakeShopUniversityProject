using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _101Shop.Models;
using _101Shop.ViewModels;

namespace _101Shop.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public CakeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CakeViewModel vm)
        {
            var model = _cakeRepository.Create(vm.Name, vm.ShortDescription, vm.LongDescription, vm.Price);

            return RedirectToAction(nameof(Create));
        }

        public IActionResult List()
        {
            var cakes = _cakeRepository.GetAllCakes();
            var test = cakes.Select(cake => new CakeViewModel
            {
                CakeId = cake.CakeId,
                Name = cake.Name,
                ShortDescription = cake.ShortDescription,
                LongDescription = cake.LongDescription,
                Price = cake.Price,
                InStock = cake.InStock,
                ImageUrl = cake.ImageUrl

            });
            return View(test);
        }
        public IActionResult Specials()
        {
            // TODO GetSpecialCakes
            var cakes = _cakeRepository.GetAllCakes();
            var test = cakes.Select(cake => new CakeViewModel
            {
                CakeId = cake.CakeId,
                Name = cake.Name,
                ShortDescription = cake.ShortDescription,
                LongDescription = cake.LongDescription,
                Price = cake.Price,
                InStock = cake.InStock,
                ImageUrl = cake.ImageUrl

            });
            return View(test);
        }

        public IActionResult Details(int cakeId)
        {
            var cake = _cakeRepository.GetcakeById(cakeId);
            var test = new CakeViewModel()
            {
                CakeId = cake.CakeId,
                Name = cake.Name,
                ShortDescription = cake.ShortDescription,
                LongDescription = cake.LongDescription,
                Price = cake.Price,
            };
            return View(test);
        }
    }
}
