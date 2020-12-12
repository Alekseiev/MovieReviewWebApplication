using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieReviewWebApplication.Infrastructure;
using MovieReviewWebApplication.Models;
using System.Linq;

namespace MovieReviewWebApplication.Pages
{
    public class CartModel : PageModel
    {
        private IMovieRepository repository;
        public CartModel(IMovieRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";            
        }

        public IActionResult OnPost(long movieId, string returnUrl)
        {
            Movie movie = repository.Movies
                .FirstOrDefault(movie => movie.MovieId == movieId);            
            Cart.AddItem(movie, 1);            
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long movieId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Movie.MovieId == movieId).Movie);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}