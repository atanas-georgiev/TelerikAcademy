using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MoviesApp.Data.Models;
using MoviesApp.Infrastructure;

namespace MoviesApp.Models
{
    //[Bind(Exclude = "Id")]
    public class StudioViewModel : IMapFrom<Studio>
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