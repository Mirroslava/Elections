using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionLand.Models
{
    public class StatusToUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int UserStatusId { get; set; }
        public UserStatus UserStatus { get; set; }

        //public int ElectionId { get; set; }
        //public Election Election { get; set; }
    }
}
