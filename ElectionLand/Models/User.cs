using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand.Models
{
    
    public class User
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public long PIN { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

         public string Password { get; set; }


        public List<StatusToUser> StatusToUsers { get; set; }
        public List<UserToRole> UserToRoles { get; set; }
        public List<Watcher> Watchers { get; set; }
        public List<Voice> Voices { get; set; }
        public List<UsetToVirtualDistrict> UsetToVirtualDistricts { get; set; }
        public List<CharmanDC> CharmanDCs { get; set; }
        public List<ChairmanCC> ChairmanCCs { get; set; }
        public List<Election> Elections { get; set; }
        public List<Appeal> Appeals { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
