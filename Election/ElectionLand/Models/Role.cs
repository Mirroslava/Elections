using System;
using System.Collections.Generic;

namespace ElectionLand.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<UserToRole> UserToRoles { get; set; }

    }
}
