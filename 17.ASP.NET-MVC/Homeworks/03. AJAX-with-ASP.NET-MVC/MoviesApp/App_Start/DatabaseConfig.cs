using System.Data.Entity;
using MoviesApp.Data;
using MoviesApp.Data.Migrations;

namespace MoviesApp.App_Start
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesAppDbContext, Configuration>());
            new MoviesAppDbContext().Database.Initialize(true);
        }
    }
}