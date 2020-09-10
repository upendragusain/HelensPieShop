using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelensPieShop.Models;
using HelensPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelensPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies();

            var vm = new HomeViewModel()
            {
                Title = "Welcome to Helen's Pie Shop",
                Pies = pies
            };

            return View(vm);
        }

        public IActionResult Details(int pieId)
        {
            var pie = _pieRepository.GetPieById(pieId);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
