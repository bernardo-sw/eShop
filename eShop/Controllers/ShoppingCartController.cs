using Microsoft.AspNetCore.Mvc;
using eShop.Models;
using eShop.Repositories.Interfaces;
using eShop.ViewModels;

namespace eShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartController(IProductRepository productRepository,
            IShoppingCartRepository shoppingCartRepository)
        {
            _productRepository = productRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Index()
        {
            var shoppingCart = _shoppingCartRepository.GetCart();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = _shoppingCartRepository.GetShoppingCartTotal(shoppingCart.Id)
            };

            return View(shoppingCartViewModel);
        }

        public IActionResult AddItem(int productId)
        {
            Product selectedProduct = _productRepository.Products.FirstOrDefault(p => p.Id == productId);
            ISession session = HttpContext.Session;
            string shoppingCartId = session.GetString("cartId");

            if (selectedProduct != null)
            {
                _shoppingCartRepository.AddToCart(selectedProduct, shoppingCartId);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveItem(int productId)
        {
            Product selectedProduct = _productRepository.Products.FirstOrDefault(p => p.Id == productId);
            ISession session = HttpContext.Session;
            string shoppingCartId = session.GetString("cartId");

            if (selectedProduct != null)
            {
                _shoppingCartRepository.RemoveFromCart(selectedProduct, shoppingCartId);
            }
            return RedirectToAction("Index");
        }
    }
}
