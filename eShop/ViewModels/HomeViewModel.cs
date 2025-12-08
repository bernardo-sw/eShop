using TexasSteaks.Models;

namespace TexasSteaks.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Steak> FavoriteSteaks { get; set; }
    }
}
