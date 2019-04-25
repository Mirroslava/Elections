using System;
namespace ElectionLand.Models
{
    public class StatusToUser
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int UserStatusId { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
