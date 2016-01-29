using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoutubePlaylists.Data.Models;
using YoutubePlaylists.Data.Repositories;

namespace YoutubePlaylists.WebForms.Playlists
{
    public partial class Details : System.Web.UI.Page
    {
        GenericRepository<Playlist> playlists = new GenericRepository<Playlist>();
        GenericRepository<Video> videos = new GenericRepository<Video>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Playlist FormViewPlaylistDetails_SelectData([QueryString]string id)
        {
            if (id != null)
            {
                int intId = int.Parse(id);
                return this.playlists.All().FirstOrDefault(p => p.Id == intId);
            }

            return null;
        }

        public IQueryable<Video> RepeaterVideos_SelectData([QueryString]string id)
        {
            if (id != null)
            {
                int intId = int.Parse(id);
                return this.videos.All().Where(v => v.PlaylistId == intId);
            }

            return null;
        }
    }
}