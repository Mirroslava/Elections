using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand.Models
{
    public class ResultCandidate
    {
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public double OverallRating { get; set; }
        public int NumberVictoriesCantons { get; set; }
        public int CountRatingCantons { get; set; }
    }
}
