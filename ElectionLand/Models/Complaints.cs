using System;
namespace ElectionLand.Models
{
    public class Complaints
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }

        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int VirtualDistrictId { get; set; }
        public VirtualDistrict VirtualDistrict { get; set; }

        public int WatcherId { get; set; }
        public Watcher Watcher { get; set; }


    }
}
