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
                        Genre = "Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Name = "Inception",
                        Description = "Description",
                        Genre = "Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy",
                        Price = 15
                    }, new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy",
                        Price = 15
                    },
                    new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy",
                        Price = 15
                    },
                    new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy",
                        Price = 15
                    },
                    new Movie
                    {
                        Name = "DeadPool",
                        Description = "Description",
                        Genre = "Comedy",
                        Price = 15
                    },
                    new Movie
                    {
                        Name = "Chernobyl",
                        Description = "Description",
                        Genre = "Drama",
                        Price = 20
                    },
                    new Movie
                    {
                        Name = "Chernobyl",
                        Description = "Description",
                        Genre = "Drama",
                        Price = 20
                    },
                    new Movie
                    {
                        Name = "Transcendence",
                        Description = "Description",
                        Genre = "science fiction",
                        Price = 25
                    },
                    new Movie
                    {
                        Name = "Transcendence",
                        Description = "Description",
                        Genre = "science fiction",
                        Price = 25
                    }, new Movie
                    {
                        Name = "Transcendence",
                        Description = "Description",
                        Genre = "science fiction",
                        Price = 25
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}


