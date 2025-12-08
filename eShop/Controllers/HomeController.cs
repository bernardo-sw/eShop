using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using eShop.Models;
using eShop.Repositories.Interfaces;
using eShop.ViewModels;

namespace eShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new()
            {
                FavoriteProducts = _productRepository.FavoriteProducts
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
