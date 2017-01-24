namespace SocialNetwork.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Message
    {
        [Required]
        [Key]
        public int MessageId { get; set; }

        [Required]
        public int FriendshipId { get; set; }

        [ForeignKey("FriendshipId")]
        public Friendship Friendship { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public User Author { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DateTimeSent { get; set; }

        public DateTime? DateTimeSeen { get; set; }
    }
}
