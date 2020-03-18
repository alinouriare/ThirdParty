using System.Collections.Generic;
using System.Linq;

namespace Session01.TestProject.Models
{
    public class InMemoeyPersonRepository : IPersonRepository
    {

        private readonly List<Person> people = new List<Person>() {


        new Person{
        
        Id=1,
        FirstName="Ali",
        LastName="Nouri"
        }

        };
        public int Add(Person person)
        {
            person.Id = people.Count + 1;

            people.Add(person);

            return person.Id;
        }

        public List<Person> GetPeople()
        {
            return people;
        }
    }
}
