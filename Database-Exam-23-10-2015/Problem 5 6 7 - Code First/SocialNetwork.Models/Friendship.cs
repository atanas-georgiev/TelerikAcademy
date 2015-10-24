namespace SocialNetwork.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Friendship
    {
        [Required]
        [Key]
        public int FriendshipId { get; set; }

        [Required]        
        public int FirstUserId { get; set; }

        [ForeignKey("FirstUserId")]
        public User FirstUser { get; set; }

        [Required]
        public int SecondUserId { get; set; }

        [ForeignKey("SecondUserId")]
        public User SecondUser { get; set; }

        public DateTime? ApprovedDate { get; set; }
    }
}
