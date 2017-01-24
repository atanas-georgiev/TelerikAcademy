﻿namespace SocialNetwork.Data 
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    using SocialNetwork.Models;

    public class SocialNetworkContext : DbContext
    {
        public SocialNetworkContext() : 
            base("SocialNetworkDb")
        {             
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Friendship> Friendships { get; set; }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
