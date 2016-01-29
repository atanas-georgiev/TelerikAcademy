using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YoutubePlaylists.Data.Models
{
    public class Playlist
    {
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

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
