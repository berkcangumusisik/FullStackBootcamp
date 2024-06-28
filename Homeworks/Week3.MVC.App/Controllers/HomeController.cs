using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Week3.MVC.App.Models;

namespace Week3.MVC.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Hello from ViewBag!";
            ViewData["Message"] = "Hello from ViewData!";
            TempData["Message"] = "Hello from TempData!";
            var product = new ProductViewModel
            {
                Id = 1,
                Name = "Product 1",
                Price = 100,
                Description = "Description for Product 1"
            };
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
