using System.Data.Entity;
using Tweeter.Data;
using Tweeter.Data.Migrations;

namespace Tweeter.Mvc
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TweeterAppDbContext, Configuration>());
        //    TweeterAppDbContext.Create().Database.Initialize(true);
        }
    }
}