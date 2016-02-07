using System.Data.Entity;
using LibrarySystem.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LibrarySystem.Data
{
    public class LibrarySystemDbContext : IdentityDbContext<User>
    {
        public LibrarySystemDbContext() 
            : base("LibrarySystemDb", throwIfV1Schema: false)
        {
        }

        public IDbSet<Category> Categorys { get; set; }

        public IDbSet<Book> Books { get; set; }

        public static LibrarySystemDbContext Create()
        {
            return new LibrarySystemDbContext();
        }
    }
}
