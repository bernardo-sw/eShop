using Microsoft.EntityFrameworkCore;
using eShop.Context;
using eShop.Models;
using eShop.Repositories.Interfaces;
using eShop.ViewModels;

namespace eShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        private object c;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Products => _context.Products.Include(c => c.Category);

        public IEnumerable<Product> FavoriteProducts => _context.Products
            .Where(s => s.IsFavorite)
            .Include(c => c.Category);

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(s => s.Id == id);
        }

        public CategoryInfoViewModel GetCategoryInfoById(int categoryId)
        {
            var category = _context.Categories
                                .Select(c => new
                                {
                                    c.Id,
                                    c.Name,
                                    c.Description
                                }).FirstOrDefault(c => c.Id == categoryId);

            return new CategoryInfoViewModel()
            {
                Name = category.Name,
                Description = category.Description,
            };
        }
    }
}
