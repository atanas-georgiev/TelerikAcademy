using System.Collections;
using System.Collections.Generic;
using MoviesApp.Data.Models;

namespace MoviesApp.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Studio> Studios { get; set; }

        public IEnumerable<Person> People { get; set; }

        public IEnumerable<Movie> Movies { get; set; }
    }
}