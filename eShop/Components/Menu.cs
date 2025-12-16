using eShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Components
{
    public class Menu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public Menu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories.OrderBy(c => c.Name);
            return View(categories);
        }
    }
}
