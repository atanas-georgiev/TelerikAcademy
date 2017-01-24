using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace MoviesApp.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public Person Director { get; set; }

        [Required]
        public int Year { get; set; }

        public Person LeadingMaleRole { get; set; }
        public Person LeadingFeMaleRole { get; set; }
    }
}