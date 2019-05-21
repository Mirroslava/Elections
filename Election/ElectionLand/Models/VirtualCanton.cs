using System;
using System.Collections.Generic;

namespace ElectionLand.Models
{
    public class VirtualCanton
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Adress { get; set; }
        public string Centre { get; set; }


        public List<Watcher> Watchers { get; set; }
        public List<VirtualDistrict> VirtualDistricts { get; set; }
        public List<CharmanDC> CharmanDCs { get; set; }
        public List<ChairmanCC> ChairmanCCs { get; set; }
    }
}
