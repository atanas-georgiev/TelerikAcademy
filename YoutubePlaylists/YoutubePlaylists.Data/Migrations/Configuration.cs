using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

            var users = new List<User>();

            var user = new User()
            {
                UserName = "admin@site.com",
                PasswordHash = "AGeuf11D2c4lVfe55eXi3yiaQXrR9e7Zmjt1EUPrGEb/7rju+CdH6lXyU6kdQpWAhQ==",
                FirstName = "admin",
                LastName = "admin"
            };

            var user1 = new User()
            {
                UserName = "user1@site.com",
                PasswordHash = "ABc1JKUbhS+mDFRCRSfVS0Kj4NKmWIYv8r4gZD4ibGDW5hXdharkorzCgRlkGE+iVg==",
                FirstName = "user1",
                LastName = "user1"
            };

            var user2 = new User()
            {
                UserName = "user2@site.com",
                PasswordHash = "AHmk7/O3H8SD43pEE4FayawvTzLCrNRbQihSF5a88spskIs2t3UDasNA4N/QJwPJdw==",
                FirstName = "user2",
                LastName = "user2"
            };

            var user3 = new User()
            {
                UserName = "user3@site.com",
                PasswordHash = "AEfWmDWrNDWV5GbS9hzPnKGL3efLCQ4ChDyIvV0XRnyM+ZAahHkYBT1w4DjMEppFRg==",
                FirstName = "user3",
                LastName = "user3"
            };

            var user4 = new User()
            {
                UserName = "user4@site.com",
                PasswordHash = "AMqVnAXGLuaffKO+Df5u0bSWmx6LlP5NXo0C4mmwEXAq5g2RAm7NpR5+c1H/j5K05Q==",
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
                    Category = categories[i % 10],
                    User = users[i % 5],
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
    }
}
