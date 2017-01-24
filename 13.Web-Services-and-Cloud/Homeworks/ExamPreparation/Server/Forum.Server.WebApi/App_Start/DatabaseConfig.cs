namespace Forum.Server.WebApi
{
    using System.Data.Entity;

    using Forum.Data;
    using Forum.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ForumDbContext, Configuration>());
        }
    }
}
