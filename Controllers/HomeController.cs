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

        public IActionResult Index()
        {
            var products = _context.Products.Take(8).ToList();
            return View(products);
        }

		public async Task<IActionResult> ProductDetails(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var product = await _context.Products
				.FirstOrDefaultAsync(m => m.Id == id);

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
