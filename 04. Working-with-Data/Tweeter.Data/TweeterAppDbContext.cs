using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Tweeter.Data.Models;

namespace Tweeter.Data
{
    public class TweeterAppDbContext : IdentityDbContext<User>
    {
        public TweeterAppDbContext() 
            : base("TweeterApp", throwIfV1Schema: false)
        {
        }

        public IDbSet<Tweet> Tweets { get; set; }

        public IDbSet<Tag> Tags { get; set; }

        public static TweeterAppDbContext Create()
        {
            return new TweeterAppDbContext();
        }
    }
}
