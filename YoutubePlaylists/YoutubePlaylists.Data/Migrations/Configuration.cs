using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using YoutubePlaylists.Data.Models;
using Microsoft.Owin.Host.SystemWeb;

namespace YoutubePlaylists.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<YoutubePlaylistsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(YoutubePlaylistsDbContext context)
        {

            if (context.Users.Any())
            {
                return;
            }

            try
            {

                var users = new List<User>();

                var user = new User()
                {
                    UserName = "admin@site.com",
                    FirstName = "admin",
                    LastName = "admin"
                };

                var user1 = new User()
                {
                    UserName = "user1@site.com",
                    FirstName = "user1",
                    LastName = "user1"
                };

                var user2 = new User()
                {
                    UserName = "user2@site.com",
                    FirstName = "user2",
                    LastName = "user2"
                };

                var user3 = new User()
                {
                    UserName = "user3@site.com",
                    FirstName = "user3",
                    LastName = "user3"
                };

                var user4 = new User()
                {
                    UserName = "user4@site.com",
                    FirstName = "user4",
                    LastName = "user4"
                };

                context.Users.Add(user);
                context.Users.Add(user1);
                context.Users.Add(user2);
                context.Users.Add(user3);
                context.Users.Add(user4);
                users.Add(user);
                users.Add(user1);
                users.Add(user2);
                users.Add(user3);
                users.Add(user4);

                var categories = new List<Category>();

                for (int i = 0; i < 10; i++)
                {
                    var newCat = new Category()
                    {
                        Name = "Category " + i
                    };

                    context.Categories.Add(newCat);
                    categories.Add(newCat);
                }

                var playlists = new List<Playlist>();

                for (int i = 0; i < 30; i++)
                {
                    var newPl = new Playlist()
                    {
                        Title = "Playlist " + i,
                        Description = "Some Description",
                        Category = categories[i%10],
                        User = users[i%5],
                        CreationDate = DateTime.Now
                    };

                    context.Playlists.Add(newPl);
                    playlists.Add(newPl);
                }

                Random rand = new Random();

                for (int i = 0; i < 200; i++)
                {
                    context.Ratings.Add(new Rating()
                    {
                        Value = rand.Next(1, 5),
                        User = users[i%5],
                        Playlist = playlists[i%30]
                    });
                }

                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                
            }
        }
    }
}
