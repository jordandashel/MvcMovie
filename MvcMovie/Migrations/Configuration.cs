using MvcMovie.Models;

namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Robot Monster",
                    ReleaseDate = DateTime.Parse("1953-6-10"),
                    Genre = "Action",
                    Rating = "G",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Godzilla vs. Mechagodzilla II",
                    ReleaseDate = DateTime.Parse("1993-12-11"),
                    Genre = "Action",
                    Rating = "PG",
                    Price = 12.99M
                },
                new Movie    
                {
                    Title = "Rooster Cogburn",
                    ReleaseDate = DateTime.Parse("1975-10-17"),
                    Genre = "Western",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie    
                {
                    Title = "Santa Claus Conquers the Maritans",
                    ReleaseDate = DateTime.Parse("1964-11-14"),
                    Genre = "Action",
                    Rating = "PG",
                    Price = 15.99M
                });
        }
    }
}
