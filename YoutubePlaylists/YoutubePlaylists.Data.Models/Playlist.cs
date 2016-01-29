using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YoutubePlaylists.Data.Models
{
    public class Playlist
    {
        private ICollection<Rating> ratings;

        public Playlist()
        {
            this.ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Rating> Ratings
        {
            get { return this.ratings; } 
            set { this.ratings = value; }
        }
    }
}
