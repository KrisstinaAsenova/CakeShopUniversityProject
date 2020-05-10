//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using _101Shop.Models;
//using _101Shop.ViewModels;
//using Microsoft.AspNetCore.Mvc;

//namespace _101Shop.Controllers
//{
//    public class CakeController : Controller
//    {
//        private readonly IPieRepository _pieRepository;

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Detail()
//        {
//            return View();
//        }

//        public CakeController(IPieRepository pieRepository)
//        {
//            _pieRepository = pieRepository;
//        }


//        public IActionResult Details(int id)
//        {
//            var pie = _pieRepository.GetPieById(id);
//            if (pie == null)
//                return NotFound();

//            return View(pie);
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Create(PieViewModel vm)
//        {
//            var model = _pieRepository.Create(vm.Name, vm.ShortDescription, vm.LongDescription, vm.Price);

//            return RedirectToAction(nameof(Create));
//        }
//    }
//}