using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MovieReviewWebApplication.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDbContext context;

        public EFMovieRepository(MovieDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Movie> Movies => context.Movies
            .Include(m => m.Genres);

        public void CreateMovie(Movie movie)
        {
            context.Add(movie);
            context.SaveChanges();
        }

        public void DeleteMovie(Movie movie)
        {
            context.Movies.Remove(movie);            
            context.SaveChanges();
        }

        public void SaveMovie(Movie movie)
        {
            context.SaveChanges();
        }
    }
}
