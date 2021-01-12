using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MovieReviewWebApplication.Models
{
    public class EFGenreRepository : IGenreRepository
    {
        private MovieDbContext context;

        public EFGenreRepository(MovieDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Genre> Genres => context.Genres
            .Include(g => g.Movies);

    }

}
