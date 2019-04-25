using System;
namespace ElectionLand.Models
{
    public class UsetToVirtualDistrict
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int VirtualDistrictId { get; set; }
        public VirtualDistrict VirtualDistrict { get; set; }
    }
}
