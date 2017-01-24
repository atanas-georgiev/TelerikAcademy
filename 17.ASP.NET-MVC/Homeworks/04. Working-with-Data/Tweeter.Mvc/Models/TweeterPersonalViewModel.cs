using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tweeter.Data.Models;
using Tweeter.Mvc.Infrastructure.Mappings;

namespace Tweeter.Mvc.Models
{
    public class TweeterPersonalViewModel : IMapFrom<Tweet>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [UIHint("StringSingleLine")]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        [UIHint("StringSingleLine")]
        public string Content { get; set; }
    }
}