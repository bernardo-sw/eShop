using Microsoft.AspNetCore.Mvc;
using TexasSteaks.Repositories.Interfaces;
using TexasSteaks.ViewModels;

namespace TexasSteaks.Controllers
{
    public class SteakController : Controller
    {
        private readonly ISteakRepository _steakRepository;

        public SteakController(ISteakRepository steakRepository)
        {
            _steakRepository = steakRepository;
        }

        public IActionResult List()
        {
            SteakListViewModel steaksListViewModel = new()
            {
                Steaks = _steakRepository.Steaks,
                CurrentCategory = "Categoria Atual"
            };
            return View(steaksListViewModel);
        }
    }
}
