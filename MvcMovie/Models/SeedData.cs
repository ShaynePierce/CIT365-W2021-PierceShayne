using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure",
                        Price = 7.99M,
                        Rating = "PG",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/1/1f/17miracles.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "PG",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/1/11/The_Other_Side_of_Heaven_theatrical_poster.png"
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2003-09-11"),
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "PG-13",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/0/07/Saints_and_soldiers.jpg"
                    },

                    new Movie
                    {
                        Title = "God's Army",
                        ReleaseDate = DateTime.Parse("2000-03-10"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "PG",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/e/e9/Godsarmy.jpg"
                    },

                    new Movie
                    {
                        Title = "The Cokeville Miracle",
                        ReleaseDate = DateTime.Parse("2015-06-05"),
                        Genre = "Drama",
                        Price = 6.99M,
                        Rating = "PG-13",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/f/ff/Thecokevillemiracleposter.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 0.0M,
                        Rating = "PG",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/1/17/Meet_the_Mormons_poster.jpg"
                    },

                    new Movie
                    {
                        Title = "Once I Was a Beehive",
                        ReleaseDate = DateTime.Parse("2015-08-15"),
                        Genre = "Comedy",
                        Price = 5.99M,
                        Rating = "PG",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/2/22/Once_I_Was_a_Beehive_%282015%29.jpg"
                    },

                    new Movie
                    {
                        Title = "Freetown",
                        ReleaseDate = DateTime.Parse("2015-04-08"),
                        Genre = "Thriller",
                        Price = 5.99M,
                        Rating = "PG-13",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/b/be/Freetown_%282015%29.jpg"
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2010-10-01"),
                        Genre = "Action",
                        Price = 7.99M,
                        Rating = "PG-13",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/0/08/The_Saratov_Approach_DVD_Cover.jpg"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2003-01-01"),
                        Genre = "Comedy",
                        Price = 3.99M,
                        Rating = "PG",
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/0/0c/Poster_of_the_movie_The_Best_Two_Years.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}