using Microsoft.AspNetCore.Mvc;
using TexasSteaks.Models;
using TexasSteaks.Repositories.Interfaces;
using TexasSteaks.ViewModels;

namespace TexasSteaks.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISteakRepository _steakRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartController(ISteakRepository steakRepository,
            IShoppingCartRepository shoppingCartRepository)
        {
            _steakRepository = steakRepository;
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

        public IActionResult AddItem(int steakId)
        {
            Steak selectedSteak = _steakRepository.Steaks.FirstOrDefault(p => p.Id == steakId);
            ISession session = HttpContext.Session;
            string shoppingCartId = session.GetString("cartId");

            if (selectedSteak != null)
            {
                _shoppingCartRepository.AddToCart(selectedSteak, shoppingCartId);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveItem(int steakId)
        {
            Steak selectedSteak = _steakRepository.Steaks.FirstOrDefault(p => p.Id == steakId);
            ISession session = HttpContext.Session;
            string shoppingCartId = session.GetString("cartId");

            if (selectedSteak != null)
            {
                _shoppingCartRepository.RemoveFromCart(selectedSteak, shoppingCartId);
            }
            return RedirectToAction("Index");
        }
    }
}
