using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using YoutubePlaylists.Data.Models;
using YoutubePlaylists.Data.Repositories;

namespace YoutubePlaylists.WebForms.Admin.Playlists
{
    public partial class Create : System.Web.UI.Page
    {
        GenericRepository<Category> categories = new GenericRepository<Category>();
        GenericRepository<Video> videos = new GenericRepository<Video>();
        GenericRepository<Playlist> playlists = new GenericRepository<Playlist>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["videos"] == null)
            {
                Session["videos"] = new List<string>();
            }
        }

        public IQueryable<Category> DropDownListCategory_Select()
        {
            return categories.All();
        }

        public IEnumerable RepeaterUrls_Select()
        {
            return Session["videos"] as List<string>;
        }

        protected void OnAddUrlClick(object sender, EventArgs e)
        {
            (Session["videos"] as List<string>).Add(this.TextBoxAddUrl.Text);

            this.RepeaterUrls.DataBind();
        }

        protected void ButtonCreate_OnClick(object sender, EventArgs e)
        {
            var selectedCategory = categories.All().FirstOrDefault(c => c.Name == DropDownListCategory.SelectedValue);
            var newPlaylist = new Playlist();
            newPlaylist.Title = TextBoxTitle.Text;
            newPlaylist.Description = TextBoxDescription.Text;
            newPlaylist.UserId = Page.User.Identity.GetUserId();
            newPlaylist.CategoryId = selectedCategory.Id;
            newPlaylist.CreationDate = DateTime.UtcNow;

            playlists.Add(newPlaylist);
            playlists.SaveChanges();
            var videosToAdd = Session["videos"] as List<string>;

            for (int i = 0; i < videosToAdd.Count; i++)
            {
                videos.Add(new Video()
                {
                    Url = videosToAdd[i],
                    Playlist = newPlaylist
                });

                videos.SaveChanges();
            }

            Response.Redirect("~/Home.aspx");

        }
    }
}