using eShop.Models;

namespace eShop.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> FavoriteProducts { get; }
        Product GetProductById(int id);
    }
}
