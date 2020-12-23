using System.Linq;

namespace MovieReviewWebApplication.Models
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }

        void SaveMovie(Movie movie);
        void CreateMovie(Movie movie);
        void DeleteMovie(Movie movie);
    }
}
