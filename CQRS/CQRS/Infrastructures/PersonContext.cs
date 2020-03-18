using CQRS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Infrastructures
{
  public  class PersonContext:DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options):base(options)
        {
            
        }

        public DbSet<Person>  People { get; set; }

    }
}
