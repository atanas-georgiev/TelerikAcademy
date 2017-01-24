using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using Tweeter.Data.Models;
using Tweeter.Mvc.Infrastructure.Mappings;
using Tweeter.Mvc.Infrastructure.Validation;

namespace Tweeter.Mvc.Models
{
    public class TweetViewModel : IMapFrom<Tweet>
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [UIHint("StringSingleLine")]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        [UIHint("StringSingleLine")]
        public string Content { get; set; }

        [Required]
        [AtLeastThreeTags]
        [UIHint("StringSingleLine")]
        public string Tags { get; set; }

        public User User { get; set; }
    }
}