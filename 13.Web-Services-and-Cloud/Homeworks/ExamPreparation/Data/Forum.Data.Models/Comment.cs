using System;

namespace Forum.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        [Required]
        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
