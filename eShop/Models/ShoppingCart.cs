using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Models
{
    [NotMapped]
    public class ShoppingCart
    {
        public string Id { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}