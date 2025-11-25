using Microsoft.EntityFrameworkCore;
using TexasSteaks.Context;
using TexasSteaks.Models;
using TexasSteaks.Repositories.Interfaces;

namespace TexasSteaks.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly AppDbContext _context;

        public ShoppingCartRepository(AppDbContext context)
        {
            _context = context;
        }

        public ShoppingCart GetCart(IServiceProvider services)
        {
            //Defines a session
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Gets or generates the cart ID.
            string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            //Assigns the cart ID in the Session
            session.SetString("cartId", cartId);

            //Returns the shopping cart with the assigned or obtained ID.
            return new ShoppingCart
            {
                Id = cartId
            };
        }

        public void AddToCart(int steakId, string shoppingCartId)
        {
            ShoppingCartItem shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                     s => s.Steak.Id == steakId &&
                     s.ShoppingCartId == shoppingCartId);

            if (shoppingCartItem == null)
            {
                Steak steak = _context.Steaks.SingleOrDefault(s => s.Id == steakId);
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = shoppingCartId,
                    Steak = steak,
                    Amount = 1
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }

        public void RemoveFromCart(int steakId, string shoppingCartId)
        {
            ShoppingCartItem shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                     s => s.Steak.Id == steakId &&
                     s.ShoppingCartId == shoppingCartId);

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _context.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return _context.ShoppingCartItems.Include(s => s.Steak).ToList();
        }

        public void CleanCart(string shoppingCartId)
        {
            IQueryable<ShoppingCartItem> cartItems = _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == shoppingCartId);

            _context.ShoppingCartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }

        public decimal GetShoppingCartTotal(string shoppingCartId)
        {
            return _context.ShoppingCartItems.Where(c => c.ShoppingCartId == shoppingCartId)
                .Select(c => c.Steak.Price * c.Amount).Sum();
        }
    }
}
