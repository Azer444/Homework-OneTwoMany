using Fiorello.Data;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List <Slider> sliders = _context.Sliders.ToList();
            SliderDetail sliderDetail = _context.SliderDetails.FirstOrDefault();
            List<FlowerExpert> flowerExpert = _context.FlowerExperts.ToList();
            HomeVM model = new HomeVM
            {
                SliderDetail = sliderDetail,
                Sliders = sliders,
                FlowerExperts = flowerExpert


            };

            return View(model);
        }
      
    }
}
