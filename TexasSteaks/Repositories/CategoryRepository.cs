using TexasSteaks.Context;
using TexasSteaks.Models;
using TexasSteaks.Repositories.Interfaces;

namespace TexasSteaks.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}
