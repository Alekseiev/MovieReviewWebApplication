using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MovieReviewWebApplication.Models;

namespace MovieReviewWebApplication.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IGenreRepository repository;

        public NavigationMenuViewComponent(IGenreRepository repository)
        {
            this.repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Genres
                .Select(genre => genre.Name)                
                .ToList());
        }
    }
}
