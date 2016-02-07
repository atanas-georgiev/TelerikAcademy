using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibrarySystem.Data.Models;
using LibrarySystem.Infrastructure.Mappings;

namespace LibrarySystem.Models.Categories
{
    public class AddCategoryViewModel : IMapFrom<Category>
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
    }
}