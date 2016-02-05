using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tweeter.Data.Models
{
    public class Tweet
    {
        private ICollection<Tag> tags;

        public Tweet()
        {
            this.tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }
    }
}
