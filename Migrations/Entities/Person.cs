using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Person
    {

        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Contact>  Contacts { get; set; }

        public List<Car> Cars { get; set; }
    }


    public class Car
    {

        public int CarId { get; set; }

        public string CarName { get; set; }

        public int PersonId { get; set; }

        public Person  Person { get; set; }
    }
}
