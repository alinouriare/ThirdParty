using CQRS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Contracts
{
   public interface IPersonReadRepository
    {
        Person Find(int id);

        List<Person> GetAll();

     

    }


    public interface IPersonWriteRepository
    {
     

        void Add(Person person);

        void Upadte(Person person);

    }
}
