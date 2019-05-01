using System;
using System.Collections.Generic;

namespace ElectionLand.Models
{
    public class UserStatus
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public List<StatusToUser> StatusToUsers{ get; set; }
    }
}
