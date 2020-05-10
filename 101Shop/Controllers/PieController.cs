using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _101Shop.Models;
using _101Shop.ViewModels;

namespace _101Shop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PieViewModel vm)
        {
            var model = _pieRepository.Create(vm.Name, vm.ShortDescription, vm.LongDescription, vm.Price);

            return RedirectToAction(nameof(Create));
        }

        public IActionResult List()
        {
            var pies = _pieRepository.GetAllPies();
            var test = pies.Select(pie => new PieViewModel
            {
                PieId = pie.PieId,
                Name = pie.Name,
                ShortDescription = pie.ShortDescription,
                LongDescription = pie.LongDescription,
                Price = pie.Price,
                InStock = pie.InStock,
                ImageUrl = pie.ImageUrl

            });
            return View(test);
        }

        public IActionResult Details(int pieId)
        {
            var pie = _pieRepository.GetPieById(pieId);
            var test = new PieViewModel()
            {
                PieId = pie.PieId,
                Name = pie.Name,
                ShortDescription = pie.ShortDescription,
                LongDescription = pie.LongDescription,
                Price = pie.Price,
            };
            return View(test);
        }
    }
}
