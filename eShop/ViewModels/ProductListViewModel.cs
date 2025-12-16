using eShop.Models;

namespace eShop.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public CategoryInfoViewModel CurrentCategory { get; set; }
    }
}
