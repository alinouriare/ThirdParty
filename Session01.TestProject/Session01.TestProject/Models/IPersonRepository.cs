using System.Collections.Generic;

namespace Session01.TestProject.Models
{
    public interface IPersonRepository
    {

        int Add(Person person);

        List<Person> GetPeople();
    }
}
