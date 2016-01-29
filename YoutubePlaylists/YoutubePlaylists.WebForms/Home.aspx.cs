using System;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;
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
            var result = this.playlists.All().OrderByDescending(p => p.Ratings.Sum(r => r.Value));
            return result;
        }

        protected void OnCommand(object sender, CommandEventArgs e)
        {
            var categoryName = (string)e.CommandArgument;
            Response.Redirect("Playlists/All.aspx?category=" + categoryName);

        }
    }
}