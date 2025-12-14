using eShop.Models;
using eShop.Repositories.Interfaces;
using eShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartSummary(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        public IViewComponentResult Invoke()
        {
            var shoppingCart = _shoppingCartRepository.GetCart();

            // Code snippet for testing the item count in the shopping cart.
            //var items = new List<ShoppingCartItem>()
            //{
            //    new ShoppingCartItem(),
            //    new ShoppingCartItem()
            //};

            //ShoppingCart shoppingCart = new ShoppingCart()
            //{
            //    ShoppingCartItems = items
            //};
            // End of test segment.

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = _shoppingCartRepository.GetShoppingCartTotal(shoppingCart.Id)
            };

            return View(shoppingCartViewModel);
        }
    }
}
