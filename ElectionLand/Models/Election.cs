using System;
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
    }
}
