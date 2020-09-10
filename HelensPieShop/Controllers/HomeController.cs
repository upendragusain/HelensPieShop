using System.Linq;
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
            var pies = _pieRepository.GetAllPies().Select(_ => Map(_));

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

            return View(Map(pie));
        }

        private Pie Map(Infrastructure.Pie pie)
        {
            return new Pie()
            {
                ImageThumbnailUrl = pie.ImageThumbnailUrl,
                ImageUrl = pie.ImageUrl,
                IsPieOfTheWeek = pie.IsPieOfTheWeek,
                LongDescription = pie.LongDescription,
                Name = pie.Name,
                PieId = pie.PieId,
                Price = pie.Price,
                ShortDescription = pie.ShortDescription
            };
        }
    }
}
