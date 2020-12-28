using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieReviewWebApplication.Models;
using MovieReviewWebApplication.Models.ViewModels;


namespace PracticeWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IMovieRepository repository;        
        public int PageSize = 4;

        public HomeController(IMovieRepository repository)
        {
            this.repository = repository;            
        }

        public ViewResult Index(string category, int moviePage = 1)
        {
            return View(new MoviesListViewModel
            {
                Movies = repository.Movies
                .Where(movie => category == null || movie.Genre == category)
                    .OrderBy(movie => movie.MovieId)
                    .Skip((moviePage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = moviePage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Movies.Count() :
                        repository.Movies.Where(movie =>
                        movie.Genre == category).Count()
                },
                CurrentCategory = category
            });
        }
    }
}
