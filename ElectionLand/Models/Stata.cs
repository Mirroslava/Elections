using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand.Models
{
    public class Stata
    {
        public int CandidateId { get; set; }
        
        public Candidate Candidate { get; set; }

        public int CountVoiceCondidate { get; set; }

        public double Percent { get; set; }

        public int CountWinCanton { get; set; }

        public int CountWinDistinc { get; set; }
    }
}
