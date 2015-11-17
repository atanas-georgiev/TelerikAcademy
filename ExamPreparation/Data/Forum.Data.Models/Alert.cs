namespace Forum.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Alert
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Content { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
