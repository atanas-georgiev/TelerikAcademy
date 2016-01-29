using System;
using System.Linq;
using Microsoft.AspNet.Identity;
using YoutubePlaylists.Data.Models;
using YoutubePlaylists.Data.Repositories;

namespace YoutubePlaylists.WebForms.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        GenericRepository<User> users = new GenericRepository<User>();

        protected void Page_Load()
        {
           
        }

        public Data.Models.User FormViewUserDetails_SelectData()
        {
            var currentUserId = Page.User.Identity.GetUserId();
            return users.All().FirstOrDefault(u => u.Id == currentUserId);
        }

        protected void ButtonUpdate_OnClick(object sender, EventArgs e)
        {
           
        }
    }
}