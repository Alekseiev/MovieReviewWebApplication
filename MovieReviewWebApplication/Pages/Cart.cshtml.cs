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
        public CartModel(IMovieRepository repo)
        {
            repository = repo;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long movieId, string returnUrl)
        {
            Movie movie = repository.Movies
                .FirstOrDefault(movie => movie.MovieId == movieId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(movie, 1);
            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}