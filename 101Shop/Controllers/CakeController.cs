using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _101Shop.Models;
using _101Shop.ViewModels;
using Microsoft.AspNetCore.Identity;
using _101Shop.Services.Contracts;

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
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CakeViewModel vm)
        {
            var model = await Task.Run(() => _cakeRepository.Create(vm.Name, vm.ShortDescription, vm.LongDescription, vm.Price, vm.AllergyInformation, vm.ImageUrl, vm.IsSpecial));

            return RedirectToAction(nameof(Create));
        }

        
        [HttpPost]
        public async Task<IActionResult> AddComment(CakeViewModel vm)
        {
            var comment = new Comment()
            {
                CakeId = vm.CakeId,
                UserName = _userManager.GetUserAsync(User).Result.UserName,
                Text = vm.Text,
                Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
            if (!string.IsNullOrEmpty(comment.Text))
            {
                var model = await Task.Run(() => _cakeRepository.AddComment(comment));
            }
            

            return RedirectToAction(nameof(Details), new { cakeId = vm.CakeId });
        }

        public async Task<IActionResult> Remove(int cakeId)
        {
            var cake = await Task.Run(() => _cakeRepository.cakes.FirstOrDefault(p => p.CakeId == cakeId));
            await Task.Run(() => _cakeRepository.RemoveCake(cakeId));

            if (cake.IsSpecial)
            {
                return RedirectToAction("Specials", "Cake");
            }
            else
            {
                return RedirectToAction("List", "Cake");
            }
        }

        public async Task<IActionResult> EditCake(CakeViewModel vm)
        {
            var cake = await Task.Run(() => _cakeRepository.cakes.FirstOrDefault(p => p.CakeId == vm.CakeId));
            await Task.Run(() => _cakeRepository.EditCake(vm));

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
        public async Task<IActionResult> GetCake(int cakeId)
        {
            var cake = await Task.Run(() => _cakeRepository.GetcakeById(cakeId));
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

        public async Task<IActionResult> List()
        {
            var cakes = await Task.Run(() => _cakeRepository.GetAllCakes());
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
        public async Task<IActionResult> Specials()
        {
            var specialCakes = await Task.Run(() => _cakeRepository.GetAllSpecialCakes());
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

        public async Task<IActionResult> Details(int cakeId)
        {
            var cake = await Task.Run(() => _cakeRepository.GetcakeById(cakeId));
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
