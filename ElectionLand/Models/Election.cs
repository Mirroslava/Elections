using System;
using System.Collections.Generic;

namespace ElectionLand.Models
{
    public class Election
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public DateTime StartElection { get; set; }
        public DateTime EndElection { get; set; }
        public int ChairmanСVK{ get; set; }

        public List<Watcher> Watchers { get; set; }
        public List<Voice> Voices { get; set; }
        public List <Complaints> Complaints { get; set; }
        public List <CharmanDC> CharmanDCs { get; set; }
        public List<ChairmanCC> ChairmanCCs { get; set; }
        public List <Election> Elections { get; set; }
        public List <Appeal> Appeals { get; set; }
    }
}
