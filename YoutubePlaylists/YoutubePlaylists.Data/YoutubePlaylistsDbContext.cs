using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using YoutubePlaylists.Data.Models;

namespace YoutubePlaylists.Data
{
    public class YoutubePlaylistsDbContext : IdentityDbContext<User>, IYoutubePlaylistsDbContext
    {
        public YoutubePlaylistsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<TextExamItem> TextExamItems { get; set; }

        public static YoutubePlaylistsDbContext Create()
        {
            return new YoutubePlaylistsDbContext();
        }
    }
}
