using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesApp.Data.Models;

namespace MoviesApp.Data
{
    public class MoviesAppDbContext : DbContext
    {
        public MoviesAppDbContext()
            : base("DefaultConnection")
        {
        }

        public  IDbSet<Movie> Movies { get; set; }
        public  IDbSet<Person> People { get; set; }
        public  IDbSet<Studio> Studios { get; set; }
    }
}
