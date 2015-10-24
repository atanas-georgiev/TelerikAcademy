namespace SocialNetwork.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        [Required]
        [Key]
        public int ImageId { get; set; }

        [Required]
        public string Url { get; set; }

        [MinLength(5)]
        [Required]
        public string Extension { get; set; }
    }
}
