using System;
namespace ElectionLand.Models
{
    public class Appeal
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }

        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int VirtualDistrictId{ get; set; }
        public VirtualDistrict VirtualDistrict { get; set; }
    }
}
