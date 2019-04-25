using System;
namespace ElectionLand.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public int NumberInTheList { get; set; }

        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

}
}
