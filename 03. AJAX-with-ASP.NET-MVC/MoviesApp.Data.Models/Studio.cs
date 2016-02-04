using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Data.Models
{
    public class Studio
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; }
    }
}