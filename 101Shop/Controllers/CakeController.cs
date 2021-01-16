using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _101Shop.Models;
using _101Shop.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace _101Shop.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly UserManager<User> _userManager;

        public CakeController(ICakeRepository cakeRepository, UserManager<User> userManager)
        {
            _cakeRepository = cakeRepository;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CakeViewModel vm)
        {
            var model = _cakeRepository.Create(vm.Name, vm.ShortDescription, vm.LongDescription, vm.Price, vm.AllergyInformation, vm.ImageUrl, vm.IsSpecial);

            return RedirectToAction(nameof(Create));
        }

        
        [HttpPost]
        public IActionResult AddComment(CakeViewModel vm)
        {
            var user = _userManager.GetUserAsync(User);
            var userId = _userManager.GetUserId(User);
            var comment = new Comment()
            {
                CakeId = vm.CakeId,
                UserName = user.Result.UserName,
                Text = vm.Text
            };
            var model = _cakeRepository.AddComment(comment);

            return RedirectToAction(nameof(Details), routeValues: vm.CakeId);
        }

        public IActionResult Remove(int cakeId)
        {
            var cake = _cakeRepository.cakes.FirstOrDefault(p => p.CakeId == cakeId);
            _cakeRepository.RemoveCake(cakeId);

            if (cake.IsSpecial)
            {
                return RedirectToAction("Specials", "Cake");
            }
            else
            {
                return RedirectToAction("List", "Cake");
            }
        }

        public IActionResult EditCake(CakeViewModel vm)
        {
            var cake = _cakeRepository.cakes.FirstOrDefault(p => p.CakeId == vm.CakeId);
            _cakeRepository.EditCake(vm);

            if (cake.IsSpecial)
            {
                return RedirectToAction("Specials", "Cake");
            }
            else
            {
                return RedirectToAction("List", "Cake");
            }
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
                AllergyInformation = cake.AllergyInformation,
                ShortDescription = cake.ShortDescription,
                LongDescription = cake.LongDescription,
                Price = cake.Price,
                ImageUrl = cake.ImageUrl,
                Comments = cake.Comments
            };
            return View(test);
        }
    }
}
