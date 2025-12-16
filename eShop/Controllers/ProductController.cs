using Microsoft.AspNetCore.Mvc;
using eShop.Repositories.Interfaces;
using eShop.ViewModels;
using eShop.Models;

namespace eShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult List(int categoryId = 0)
        {
            IEnumerable<Product> products;
            CategoryInfoViewModel categoryInfo;

            if (categoryId == 0)
            {
                products = _productRepository.Products.OrderBy(p => p.Name);
                categoryInfo = new()
                {
                    Name = "List of Products",
                    Description = "Full list of our products that will expand your creativity (and open your palate).",
                };
            }
            else
            {
                products = _productRepository.Products
                    .Where(p => p.CategoryId == categoryId)
                    .OrderBy(p => p.Name);
                categoryInfo = _productRepository.GetCategoryInfoById(categoryId);
            }

            ProductListViewModel productsListViewModel = new()
            {
                Products = products,
                CurrentCategory = categoryInfo
            };

            return View(productsListViewModel);
        }
    }
}
