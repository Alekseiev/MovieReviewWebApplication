using Microsoft.AspNetCore.Mvc;
using MovieReviewWebApplication.Models;
using MovieReviewWebApplication.Models.ViewModels;
using System;
using System.Linq;

namespace PracticeWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IMovieRepository movieRepository;
        private IGenreRepository genreRepository;
        public int PageSize = 8;

        public HomeController(IMovieRepository movieRepository, IGenreRepository genreRepository)
        {
            this.movieRepository = movieRepository;
            this.genreRepository = genreRepository;
        }

        public ViewResult Index(string category, int moviePage = 1)
        {
            return View(new MoviesListViewModel
            {
                Movies = movieRepository.Movies
                .Where(movie => category == null || movie.Genres.Select(genre => genre.Name).Contains(category))
                .OrderBy(movie => movie.MovieId)
                    .Skip((moviePage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = moviePage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        movieRepository.Movies.Count() :
                        movieRepository.Movies.Where(movie =>
                        movie.Genres.Select(genre => genre.Name).Contains(category)).Count()
                },
                CurrentCategory = category,
                MovieImages = movieRepository.Movies
                .OrderBy(m => m.CreatedDate)
                .Select(m => m.ImageName)
                .Take(12)
            });
        }

        public ViewResult Search(string searchString = "", int moviePage = 1)
        {
            return View("Index", new MoviesListViewModel
            {
                Movies = movieRepository.Movies
                .Where(movie => movie.Name.Contains(searchString))
                .OrderBy(movie => movie.MovieId)
                    .Skip((moviePage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = moviePage,
                    ItemsPerPage = PageSize,
                    TotalItems = movieRepository.Movies
                        .Where(movie => movie.Name.Contains(searchString)).Count()
                },
                MovieImages = movieRepository.Movies
                .OrderBy(m => m.CreatedDate)
                .Select(m => m.ImageName)
                .Take(12)
            });
        }

        public ViewResult Genres(string category, int moviePage = 1)
        {            
            return View("Index", new MoviesListViewModel
            {
                Movies = movieRepository.Movies
                .Where(movie => category == null || movie.Genres.Select(genre => genre.Name).Contains(category))
                .OrderBy(movie => movie.MovieId)                    
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = moviePage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        movieRepository.Movies.Count() :
                        movieRepository.Movies.Where(movie =>
                        movie.Genres.Select(genre => genre.Name).Contains(category)).Count()
                },
                CurrentCategory = category,
                MovieImages = movieRepository.Movies
                .OrderBy(m => m.CreatedDate)
                .Select(m => m.ImageName)
                .Take(12)
            });
        }
    }
}
