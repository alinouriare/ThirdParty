using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session01.TestProject.Models
{
    public class EfPersonRepository : IPersonRepository
    {
        private readonly PersonDb personDb;

        public EfPersonRepository(PersonDb personDb)
        {
            this.personDb = personDb;
        }
        public int Add(Person person)
        {
            personDb.Add(person);
            personDb.SaveChanges();

            return person.Id;

        }

        public List<Person> GetPeople()
        {
            return personDb.people.ToList();
                }
    }
}
