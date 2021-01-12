using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MovieReviewWebApplication.Models
{
    public class GenreSeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            MovieDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<MovieDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            Genre genre = new Genre { Name = "action" };

            if (!context.Genres.Any())
            {
                context.Genres.AddRange(
                    new Genre
                    {
                        Name = "Action"
                    },
                    new Genre
                    {
                        Name = "Comedy"
                    },
                    new Genre
                    {
                        Name = "Drama"
                    },
                    new Genre
                    {
                        Name = "Science Fiction"
                    });
                context.SaveChanges();
            }
        }
    }
}
