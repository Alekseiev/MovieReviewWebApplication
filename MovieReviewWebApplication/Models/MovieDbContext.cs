using Microsoft.EntityFrameworkCore;

namespace MovieReviewWebApplication.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(t => t.Genres)
                .WithMany(t => t.Movies)
                .UsingEntity(j =>
                {
                    j.ToTable("MovieGenres");
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
