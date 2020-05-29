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

        //Как се вика Create метода ???
        [HttpPost]
        public IActionResult Create(CakeViewModel vm)
        {
            var model = _cakeRepository.Create(vm.Name, vm.ShortDescription, vm.LongDescription, vm.Price, vm.AllergyInformation, vm.ImageUrl, vm.IsSpecial);

            return RedirectToAction(nameof(Create));
        }

        public IActionResult Remove(int cakeId)
        {
            _cakeRepository.RemoveCake(cakeId);

            return RedirectToAction(nameof(List));
        }

        public IActionResult EditCake(int cakeId)
        {
            //TODO call this method with CakeViewModel parameter
            //var cakeToEdit = _cakeRepository.GetcakeById(cakeId);

            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult GetCake(int cakeId)
        {
            var cake=_cakeRepository.GetcakeById(cakeId);
            var cakeViewModelToEdit = new CakeViewModel
            {
                CakeId = cake.CakeId,
                Name = cake.Name,
                ShortDescription = cake.ShortDescription,
                LongDescription = cake.LongDescription,
                Price = cake.Price,
                ImageUrl = cake.ImageUrl,
                AllergyInformation = cake.AllergyInformation,
                IsSpecial = cake.IsSpecial

            };
            return View("EditCake",cakeViewModelToEdit);
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
                ImageUrl = cake.ImageUrl

            });
            return View(test);
        }
        public IActionResult Specials()
        {
            var specialCakes = _cakeRepository.GetAllSpecialCakes();
            var test = specialCakes.Select(cake => new CakeViewModel
            {
                CakeId = cake.CakeId,
                Name = cake.Name,
                ShortDescription = cake.ShortDescription,
                LongDescription = cake.LongDescription,
                Price = cake.Price,
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
