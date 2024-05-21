using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsMVC.Data;
using ProductsMVC.Models;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ProductsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // This code should be within a ProductsService class
        private readonly ProductsContext _context;

        public HomeController(ILogger<HomeController> logger, ProductsContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _service
                .GetFirst8();

            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public async Task<IActionResult> ProductDetails(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var product = await _service
                .GetProduct(id.Value);

			if (product == null)
			{
				return NotFound();
			}

			return View(product);
		}

		public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DetailsPartial()
        {
            return PartialView("_Details");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
