using System;
using System.Collections.Generic;

namespace DAL
{
    public partial class Contacts
    {
        public int ContactId { get; set; }
        public string AddressLine { get; set; }
        public int PersonId { get; set; }

        public virtual People Person { get; set; }
    }
}
