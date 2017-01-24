namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Net.Mime;

    public class Post
    {
        private ICollection<User> users;

        public Post()
        {
            this.users = new HashSet<User>();
        }

        [Required]
        [Key]
        public int PostId { get; set; }

        [Required]
        [MinLength(10)]
        public string Content { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }
    }
}
