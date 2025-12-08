using Microsoft.AspNetCore.Mvc;
using eShop.Repositories.Interfaces;
using eShop.ViewModels;

namespace eShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult List()
        {
            ProductListViewModel productsListViewModel = new()
            {
                Products = _productRepository.Products,
                CurrentCategory = "Categoria Atual"
            };
            return View(productsListViewModel);
        }
    }
}
