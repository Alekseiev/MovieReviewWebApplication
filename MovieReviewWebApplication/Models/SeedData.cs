using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MovieReviewWebApplication.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            MovieDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<MovieDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(                    
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action"
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action"
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action"
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action"
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action"
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action"
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action"
                    },
                    new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy"
                    }, new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy"
                    },
                    new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy"
                    },
                    new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy"
                    },
                    new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy"
                    },
                    new Movie
                    {
                        Name = "Chernobyl",
                        Description = "Description",
                        Genre = "Drama"
                    },
                    new Movie
                    {
                        Name = "Chernobyl",
                        Description = "Description",
                        Genre = "Drama"
                    },
                    new Movie
                    {
                        Name = "Transcendence",
                        Description = "Description",
                        Genre = "science fiction"
                    },
                    new Movie
                    {
                        Name = "Transcendence",
                        Description = "Description",
                        Genre = "science fiction"
                    }, new Movie
                    {
                        Name = "Transcendence",
                        Description = "Description",
                        Genre = "science fiction"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
    

