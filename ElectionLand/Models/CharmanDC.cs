using System;
namespace ElectionLand.Models
{
    public class CharmanDC
    {
        public int Id { get; set; }

        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int VirtualCantonId { get; set; }
        public VirtualCanton VirtualCanton { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
