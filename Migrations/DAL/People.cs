using System;
using System.Collections.Generic;

namespace DAL
{
    public partial class People
    {
        public People()
        {
            Contacts = new HashSet<Contacts>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Contacts> Contacts { get; set; }
    }
}
