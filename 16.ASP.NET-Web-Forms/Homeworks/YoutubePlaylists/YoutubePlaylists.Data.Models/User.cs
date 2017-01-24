using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace YoutubePlaylists.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(55)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(55)]
        public string LastName { get; set; }

        [MaxLength(200)]
        public string ImageUrl { get; set; }

        [MaxLength(200)]
        public string FacebookUrl { get; set; }

        [MaxLength(200)]
        public string YoutubeUrl { get; set; }

        public ClaimsIdentity GenerateUserIdentity(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }
    }
}
