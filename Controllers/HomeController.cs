using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsMVC.Data;
using ProductsMVC.Data.Services;
using ProductsMVC.Models;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ProductsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _service;

        public HomeController(IProductService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var products = _service.GetFirst8();
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

			var product = await _service.GetProduct(id.Value);

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
