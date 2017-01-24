namespace Forum.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Forum.Data.Models;

    using Microsoft.AspNet.Identity.EntityFramework;

    public class ForumDbContext : IdentityDbContext<User>, IForumDbContext
    {
        public IDbSet<Article> Articles { get; set; }

        public IDbSet<Like> Likes { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Tag> Tags { get; set; }

        public IDbSet<Alert> Alerts { get; set; }

        public ForumDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ForumDbContext Create()
        {
            return new ForumDbContext();
        }
    }
}
