using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubePlaylists.Data.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 5)]
        public int Value { get; set; }

 //       public int PlaylistId { get; set; }

 //       public virtual Playlist Playlist { get; set; }

//        public string UserId { get; set; }
//
//        public virtual User User { get; set; }
    }
}
