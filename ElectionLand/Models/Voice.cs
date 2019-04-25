using System;
namespace ElectionLand.Models
{
    public class Voice
    {

        public int Id { get; set; }

        public int ElectionId { get; set; }
        public  Election Election { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

        public int CandidatId { get; set; }
        public Candidate Candidate { get; set; }

        public int VirtualDistrictId { get; set; }
        public VirtualDistrict VirtualDistrict { get; set; }

    }
}
