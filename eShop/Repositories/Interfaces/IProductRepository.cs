using eShop.Models;
using eShop.ViewModels;

namespace eShop.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> FavoriteProducts { get; }
        Product GetProductById(int id);
        CategoryInfoViewModel GetCategoryInfoById(int categoryId);
    }
}
