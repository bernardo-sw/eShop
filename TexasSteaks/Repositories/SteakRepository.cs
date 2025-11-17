using Microsoft.EntityFrameworkCore;
using TexasSteaks.Context;
using TexasSteaks.Models;
using TexasSteaks.Repositories.Interfaces;

namespace TexasSteaks.Repositories
{
    public class SteakRepository : ISteakRepository
    {
        private readonly AppDbContext _context;
        public SteakRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<Steak> Steaks => _context.Steaks.Include(c => c.Category);

        public IEnumerable<Steak> FavoritesSteaks => _context.Steaks
            .Where(s => s.IsFavorite)
            .Include(c => c.Category);

        public Steak GetSteakById(int id)
        {
            return _context.Steaks.FirstOrDefault(s => s.Id == id);
        }
    }
}
