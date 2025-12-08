using eShop.Models;

namespace eShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FavoriteProducts { get; set; }
    }
}
