using System;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.ModelBinding;
using YoutubePlaylists.Data.Models;
using YoutubePlaylists.Data.Repositories;

namespace YoutubePlaylists.WebForms
{
    public partial class Home : System.Web.UI.Page
    {
        GenericRepository<Playlist> playlists = new GenericRepository<Playlist>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Playlist> RepeaterPlaylists_GetData()
        {
            var result = this.playlists.All().OrderBy(p => p.Ratings.Sum(r => r.Value));
            return result;
        }
    }
}