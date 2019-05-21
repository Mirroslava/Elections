using System;
using System.Collections.Generic;

namespace ElectionLand.Models
{
    public class VirtualDistrict
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Adress { get; set; }

        public int VirtualCantonId { get; set; }
        public VirtualCanton VirtualCanton { get; set; }

        public List<Voice> Voices { get; set; }
        public List<UsetToVirtualDistrict> UsetToVirtualDistricts { get; set; }
        public List<Complaints> Complaints { get; set; }
        public List<Appeal> Appeals { get; set; }


    }
}
