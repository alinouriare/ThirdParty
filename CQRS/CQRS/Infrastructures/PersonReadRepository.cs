using CQRS.Contracts;
using CQRS.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CQRS.Infrastructures
{
    public class PersonReadRepository : IPersonReadRepository
    {

        //private readonly PersonContext personContext;
        // public PersonReadRepository(PersonContext personContext)
        // {
        //     this.personContext = personContext;
        // } 
        private readonly IDbConnection  dbConnection;
    
        public PersonReadRepository(string connectionString)
        {
            dbConnection = new SqlConnection(connectionString);
        }
        public Person Find(int PersonId)
        {
            Person person = dbConnection.QueryFirstOrDefault<Person>($"select * from People where Id={PersonId}");
            return person;
        }

        public List<Person> GetAll()
        {
            List<Person> people = dbConnection.Query<Person>("select * from People").ToList();
            return people;
        }
    }
}
