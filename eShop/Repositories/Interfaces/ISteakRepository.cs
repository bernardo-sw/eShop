using TexasSteaks.Models;

namespace TexasSteaks.Repositories.Interfaces
{
    public interface ISteakRepository
    {
        IEnumerable<Steak> Steaks { get; }
        IEnumerable<Steak> FavoriteSteaks { get; }
        Steak GetSteakById(int id);
    }
}
