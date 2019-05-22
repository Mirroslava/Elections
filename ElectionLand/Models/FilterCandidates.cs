using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand.Models
{
    public class FilterCandidates
    {
            public List<ResultCandidate> ResultCandidates { get; set; }
            public double OverallRating { get; set; }
            public int NumberVictoriesCantons { get; set; }
            public double RatingCantons { get; set; }
            public int CountRatingCantons { get; set; }
    }
}
