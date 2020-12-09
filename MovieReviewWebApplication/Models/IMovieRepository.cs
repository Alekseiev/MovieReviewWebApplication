using System.Linq;

namespace MovieReviewWebApplication.Models
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
