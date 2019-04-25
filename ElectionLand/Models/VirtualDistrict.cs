using System;
namespace ElectionLand.Models
{
    public class VirtualDistrict
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Adress { get; set; }

        public int VirtualCantonId { get; set; }
        public VirtualCanton VirtualCanton { get; set; }
    }
}
