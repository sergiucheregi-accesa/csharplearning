using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary.Models
{
    public class Team : DomainObject
    {
        public string Name { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
