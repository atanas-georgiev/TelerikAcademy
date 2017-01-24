namespace Task06_ImageCounterSqlServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Task06_ImageCounterSqlServer.ModelUsersDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Task06_ImageCounterSqlServer.ModelUsersDbContext context)
        {
            var user = new User() {Name = "Counter", Count = 0};
            context.User.AddOrUpdate(user);            
        }
    }
}
