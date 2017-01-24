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

namespace YoutubePlaylists.WebForms.Admin.Playlists
{
    public partial class All : System.Web.UI.Page
    {
        GenericRepository<Playlist> playlists = new GenericRepository<Playlist>();
        GenericRepository<Video> videos = new GenericRepository<Video>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Playlist> ListViewPlaylists_SelectData([QueryString]string orderBy, [QueryString]string search, [QueryString]string category)
        {
            var result = this.playlists.All();

            if (search == null)
            {
                if (orderBy == "Rating")
                {
                    result = this.playlists.All().OrderBy(p => p.Ratings.Sum(r => r.Value));
                }
                else
                {
                    result = string.IsNullOrEmpty(orderBy) ? result.OrderBy(x => x.Id) : result.OrderBy(orderBy + " Ascending");
                }
                
            }
            else
            {
                if (orderBy == "Rating")
                {
                    result = this.playlists.All().OrderBy(p => p.Ratings.Sum(r => r.Value));
                }
                else
                {
                    result = string.IsNullOrEmpty(orderBy) ? result.OrderBy(x => x.Id).Where(p => p.Title.Contains(search) || p.Description.Contains(search)) :
                                                         result.OrderBy(orderBy + " Ascending").Where(p => p.Title.Contains(search) || p.Description.Contains(search));
                }
            }

            if (category == null)
            {
                return result;
            }

            return result.Where(c => c.Category.Name == category);
        }
 
        public int GetNumberOfVideosPerPlaylistId(int id)
        {
            return videos.All().Count(v => v.Playlist.Id == id);
        }

        protected void ButtonNewPlaylist_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Playlists/Create.aspx");
        }

        protected void LinkButtonSearch_Click(object sender, EventArgs e)
        {
            string queryParam = $"All.aspx?search={this.TextBoxSearchParam.Text}";
            Response.Redirect(queryParam);
        }

    }
}