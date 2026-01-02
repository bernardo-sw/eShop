using eShop.Context;
using eShop.Models;
using eShop.Repositories.Interfaces;

namespace eShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public void CreateOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _appDbContext.ShoppingCartItems;

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
