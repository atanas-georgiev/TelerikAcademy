using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Data.Models;
using MoviesApp.Infrastructure;

namespace MoviesApp.Models
{
    public class PersonViewModel : IMapFrom<Person>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        public string StudioName { get; set; }

        public IEnumerable<string> AllStudios { get; set; }
    }
}