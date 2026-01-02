using eShop.Context;
using eShop.Models;
using eShop.Repositories.Interfaces;

namespace eShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            List<ShoppingCartItem> shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetails()
                {
                    Quantity = item.Amount,
                    ProductId = item.Product.Id,
                    OrderId = order.Id,
                    Price = item.Product.Price
                };
                _appDbContext.OrderDetails.Add(orderDetail);
            }
            _appDbContext.SaveChanges();
        }
    }
}
