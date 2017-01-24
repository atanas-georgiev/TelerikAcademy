using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string ISBN { get; set; }

        [MaxLength(100)]
        public string WebSite { get; set; }

        [Required]
        [MaxLength(300)]
        public string Author { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
