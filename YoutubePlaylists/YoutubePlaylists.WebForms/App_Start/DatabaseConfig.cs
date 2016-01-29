using System.Data.Entity;
using YoutubePlaylists.Data;
using YoutubePlaylists.Data.Migrations;

namespace YoutubePlaylists.WebForms
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<YoutubePlaylistsDbContext, Configuration>());
            YoutubePlaylistsDbContext.Create().Database.Initialize(true);
        }
    }
}