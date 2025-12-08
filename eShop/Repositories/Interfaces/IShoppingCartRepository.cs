using eShop.Models;

namespace eShop.Repositories.Interfaces
{
    public interface IShoppingCartRepository
    {
        ShoppingCart GetCart();
        void AddToCart(Product product, string shoppingCartId);
        void RemoveFromCart(Product product, string shoppingCartId);
        List<ShoppingCartItem> GetShoppingCartItems();
        void CleanCart(string shoppingCartId);
        decimal GetShoppingCartTotal(string shoppingCartId);
    }
}
