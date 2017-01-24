using System.Data.Entity;
using LibrarySystem.Data;
using LibrarySystem.Data.Migrations;

namespace LibrarySystem
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibrarySystemDbContext, Configuration>());
        }
    }
}