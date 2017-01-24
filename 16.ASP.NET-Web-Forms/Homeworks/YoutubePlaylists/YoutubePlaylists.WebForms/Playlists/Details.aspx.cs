using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using YoutubePlaylists.Data.Models;
using YoutubePlaylists.Data.Repositories;
using YoutubePlaylists.WebForms.Controls;

namespace YoutubePlaylists.WebForms.Playlists
{
    public partial class Details : System.Web.UI.Page
    {
        GenericRepository<Playlist> playlists = new GenericRepository<Playlist>();
        GenericRepository<Video> videos = new GenericRepository<Video>();
        GenericRepository<Rating> ratings = new GenericRepository<Rating>();

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

        protected void ButtonDelete_OnClick(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            if (id != null)
            {
                int intId = int.Parse(id);
                playlists.Delete(intId);
                playlists.SaveChanges();
                
                Response.Redirect("~/Home.aspx");
            }
        }


        protected bool IsAuthor(string userId)
        {
            return Page.User.Identity.GetUserId() == userId;
        }

        protected object RemoveVideo(int id)
        {
            videos.Delete(id);
            return null;
        }

        protected void RatingControlPlaylist_OnRate(object sender, RatingEventArgs e)
        {
            string id = Request.QueryString["id"];

            try
            {
                if (id != null)
                {
                    int intId = int.Parse(id);
                    var newRating = new Rating()
                    {
                        Value = e.RatingValue,
                        UserId = Page.User.Identity.GetUserId(),
                        PlaylistId = intId
                    };

                    ratings.Add(newRating);
                    ratings.SaveChanges();
                }
            }
            catch (Exception)
            {

            }

        }

        protected void OnCommand(object sender, CommandEventArgs e)
        {
            var recordId = int.Parse((string)e.CommandArgument);
            videos.Delete(recordId);
            videos.SaveChanges();
            FormViewPlaylistDetails.DataBind();
        }
    }
}