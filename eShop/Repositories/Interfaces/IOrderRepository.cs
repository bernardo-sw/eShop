using eShop.Models;

namespace eShop.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
