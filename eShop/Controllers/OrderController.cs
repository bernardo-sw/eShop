using eShop.Models;
using eShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public OrderController(IOrderRepository orderRepository, IShoppingCartRepository shoppingCartRepository)
        {
            _orderRepository = orderRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            int totalItems = 0;
            decimal totalOrder = 0.0m;

            //Retrieves the items from the customer's shopping cart.
            ShoppingCart shoppingCart = _shoppingCartRepository.GetCart();

            //Checks if there are any order items.
            if (shoppingCart.ShoppingCartItems.Count == 0)
               ModelState.AddModelError("", "Your cart is empty, how about adding a product?");

            //Calculate the total number of items and the total order amount.
            foreach (var item in shoppingCart.ShoppingCartItems)
            {
                totalItems += item.Amount;
                totalOrder += (item.Product.Price * item.Amount);
            }

            //Assign the obtained values ​​to the request.
            order.TotalItems = totalItems;
            order.TotalOrder = totalOrder;

            //Validate the order details.
            if (ModelState.IsValid)
            {
                //Create the order and details.
                _orderRepository.CreateOrder(order);

                //Define messages for the customer.
                ViewBag.CheckoutCompleteMessage = "Thank you for your order ;)";
                ViewBag.TotalOrder = _shoppingCartRepository.GetShoppingCartTotal(shoppingCart.Id);

                //Clean the customer's shopping cart.
                _shoppingCartRepository.CleanCart(shoppingCart.Id);

                //Displays the view with customer and order data.
                return View("~/Views/Order/CheckoutComplete.cshtml", order);
            }
            return View(order);
        }
    }
}
