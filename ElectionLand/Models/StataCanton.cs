using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand.Models
{
    public class StataCanton
    {
        public int VirtualCantonId { get; set; }
        public VirtualCanton VirtualCanton { get; set; }

        public int CountVoice { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int CountVoiceCandidate { get; set; }

        public double Percent { get; set; }
    }
}
