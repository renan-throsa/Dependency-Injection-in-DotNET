using ECommerce.Domain.Entities;
using ECommerce.Domain.Abstractions;
using ECommerce.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerce.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            if (productService == null)
                throw new ArgumentNullException("productService");

            _productService = productService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = _productService.GetFeaturedProducts();
            var vm = new FeaturedProductsViewModel(from product in products select new ProductViewModel(product));
            return View(vm);
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