using System.Collections.Generic;
using System.Linq;

namespace MovieReviewWebApplication.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Movie movie, int quantity)
        {
            CartLine line = Lines
                .Where(m => m.Movie.MovieId == movie.MovieId)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Movie = movie,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity = +quantity;
            }
        }

        public virtual void RemoveLine(Movie movie) =>
            Lines.RemoveAll(l => l.Movie.MovieId == movie.MovieId);

        public decimal ComputeTotalValue() =>
            Lines.Sum(e => e.Movie.Price * e.Quantity);

        public virtual void Clear() => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Movie Movie { get; set; }
        public int Quantity { get; set; }
    }
}
