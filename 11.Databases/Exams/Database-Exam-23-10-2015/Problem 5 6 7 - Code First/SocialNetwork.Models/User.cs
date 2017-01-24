namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        private ICollection<Image> images;
        private ICollection<Post> posts;

        public User()
        {
            this.images = new HashSet<Image>();
            this.posts = new HashSet<Post>();
        }

        [Required]
        [Key]
        public int UserId { get; set; }

        [MinLength(4)]
        [MaxLength(20)]
        [Required]
        [Index(IsUnique = true)]
        public string Username { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string Lastname { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Image> Images
        {
            get { return this.images; }
            set { this.images = value; }
        }

        public virtual ICollection<Post> Posts
        {
            get { return this.posts; }
            set { this.posts = value; }
        }
    }
}
