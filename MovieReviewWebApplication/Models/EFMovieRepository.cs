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

        public IQueryable<Movie> Movies => context.Movies;
    }
}
