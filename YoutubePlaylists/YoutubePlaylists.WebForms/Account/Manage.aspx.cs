using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.UI.WebControls;
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
            FormViewUserDetails.ChangeMode(FormViewMode.Edit);
        }

        public Data.Models.User FormViewUserDetails_SelectData()
        {
            var currentUserId = Page.User.Identity.GetUserId();
            return users.All().FirstOrDefault(u => u.Id == currentUserId);
        }


        public void Update()
        {
            var currentUserId = Page.User.Identity.GetUserId();
            var userToUpdate = users.All().FirstOrDefault(u => u.Id == currentUserId);

            TryUpdateModel(userToUpdate);

            if (ModelState.IsValid)
            {
                try
                {
                    users.SaveChanges();
                }
                catch (DbUpdateException)
                {
//                    CustomValidator.IsValid = false;
//                    CustomValidator.ErrorMessage = $"Category {category.Name} already exists";
                }
            }
        }
    }
}