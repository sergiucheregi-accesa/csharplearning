using System;
using System.Collections.Generic;
using System.Text;

namespace EsportManagementApp.Models
{
    public class Player : DomainObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public Team Team { get; set; }
    }
}
