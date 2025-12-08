using TexasSteaks.Models;

namespace TexasSteaks.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
