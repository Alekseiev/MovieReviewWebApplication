using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MovieReviewWebApplication.Models;

namespace MovieReviewWebApplication.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IMovieRepository repository;

        public NavigationMenuViewComponent(IMovieRepository repository)
        {
            this.repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Movies
                .Select(movie => movie.Genre)
                .Distinct()
                .OrderBy(movie => movie));
        }
    }
}
