using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweeter.Data.Models;
using Tweeter.Mvc.Infrastructure.Mappings;
using Tweeter.Mvc.Infrastructure.Validation;

namespace Tweeter.Mvc.Areas.Admin.Models
{
    public class TweetAdminViewModel : IMapFrom<Tweet>
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }
    }
}