using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
