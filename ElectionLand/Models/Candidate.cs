using System;
using System.Collections.Generic;

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

        public List<Watcher> Watchers { get; set; }
        public List<Voice> Voices { get; set; }
        public List<Appeal> Appeals { get; set; }

    }
}
