using System;
using System.Collections.Generic;

namespace ElectionLand.Models
{
    public class Watcher
    {
       public int Id { get; set; }

        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int VirtualDistrictId { get; set; }
        public VirtualDistrict VirtualDistrict { get; set; }

        public int CandidateId{ get; set; }
        public Candidate Candidate { get; set; }

        public int UserId{ get; set; }
        public User User { get; set; }

        public List<Complaints> Complaints { get; set; }
    }
}
