using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand.Models
{
    public class SumbitCandidacy
    {
        public int Id { get; set; }
        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
