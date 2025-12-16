using eShop.Models;

namespace eShop.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
        public string CurrentCategoryDescription { get; set; }
    }
}
