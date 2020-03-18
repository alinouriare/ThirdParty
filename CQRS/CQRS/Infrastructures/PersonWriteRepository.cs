using CQRS.Contracts;
using CQRS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Infrastructures
{
    public class PersonWriteRepository : IPersonWriteRepository
    {
        private readonly PersonContext personContext;
        public PersonWriteRepository(PersonContext personContext)
        {
            this.personContext = personContext;
        }
        public void Add(Person person)
        {
            personContext.Add(person);
            personContext.SaveChanges();
        }

        public void Upadte(Person person)
        {
            personContext.Update(person);
            personContext.SaveChanges();
        }
    }
}
