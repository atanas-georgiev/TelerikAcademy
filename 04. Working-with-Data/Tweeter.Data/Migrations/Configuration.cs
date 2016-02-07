using Microsoft.AspNet.Identity;
using Tweeter.Data.Models;

namespace Tweeter.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;

    public sealed class Configuration : DbMigrationsConfiguration<Tweeter.Data.TweeterAppDbContext>
    {
        private UserManager<User> userManager;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TweeterAppDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            this.userManager = new UserManager<User>(new UserStore<User>(context));

            this.SeedRoles(context);
            this.SeedUsers(context);
            base.Seed(context);
        }

        private void SeedUsers(TweeterAppDbContext context)
        {
            var adminUser = new User
            {
                Email = "admin@site.com",
                UserName = "admin@site.com"
            };

            this.userManager.Create(adminUser, "123456");
            this.userManager.AddToRole(adminUser.Id, "Admin");
        }

        private void SeedRoles(TweeterAppDbContext context)
        {
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole("Admin"));
            context.SaveChanges();
        }
    }
}
