using Microsoft.EntityFrameworkCore;

namespace MovieReviewWebApplication.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
