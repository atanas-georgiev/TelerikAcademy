using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MoviesApp.Data.Models;
using MoviesApp.Infrastructure;

namespace MoviesApp.Models
{
    public class MovieViewModel : IMapFrom<Movie>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string DirectorName { get; set; }

        [Required]
        public int Year { get; set; }

        public string LeadingMaleRoleName { get; set; }
        public string LeadingFeMaleRoleName { get; set; }

        public IEnumerable<string> AllPeople { get; set; }
    }
}