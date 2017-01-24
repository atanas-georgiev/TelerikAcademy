using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using YoutubePlaylists.Data.Models;
using YoutubePlaylists.WebForms.Models;

namespace YoutubePlaylists.WebForms.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new User()
            {
                UserName = Email.Text,
                FirstName = TextBoxFirstName.Text,
                LastName = TextBoxLastName.Text,
                ImageUrl = TextBoxImageUrl.Text,
                FacebookUrl = TextBoxFacebookUrl.Text,
                YoutubeUrl = TextBoxYoutubeUrl.Text
            };

            IdentityResult result = IdentityResult.Failed();

            try
            {
                result = manager.Create(user, Password.Text);
            }
            catch (DbEntityValidationException ex)
            {
                
            }// todo

            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}