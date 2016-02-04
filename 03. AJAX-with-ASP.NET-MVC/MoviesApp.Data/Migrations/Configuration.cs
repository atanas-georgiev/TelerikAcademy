using System.Collections.Generic;
using System.Data.Entity.Validation;
using MoviesApp.Data.Models;

namespace MoviesApp.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<MoviesApp.Data.MoviesAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MoviesApp.Data.MoviesAppDbContext context)
        {
            if (context.Movies.Any())
            {
                return;
            }

            try
            {                
                var studio1 = new Studio()
                {
                    Name = "Universal pictures",
                    Address = "Some test address"
                    
                };

                var studio2 = new Studio()
                {
                    Name = "MGM",
                    Address = "Some test address"

                };
                
//                context.Studios.Add(studio1);
//                context.Studios.Add(studio2);

                var person1 = new Person()
                {
                    Name = "Brat Pitt",
                    Age = 50,
                    Studio = studio1
                };

                var person2 = new Person()
                {
                    Name = "Agelina Jolly",
                    Age = 35,
                    Studio = studio2
                };

//                context.People.Add(person1);
//                context.People.Add(person2);

                var movie1 = new Movie()
                {
                    Title = "Some movie title1",
                    Director = person1,
                    LeadingMaleRole = person1,
                    LeadingFeMaleRole = person2,
                    Year = 2000
                };

                var movie2 = new Movie()
                {
                    Title = "Some movie title2",
                    Director = person2,
                    LeadingMaleRole = person2,
                    LeadingFeMaleRole = person1,
                    Year = 2016
                };

                context.Movies.Add(movie1);
                context.Movies.Add(movie2);

                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

            }
        }
    }
}
