using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Session01.TestProject.Models
{
    public class Person
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


    }

    public class PersonDb : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; initial catalog = PersonDb; integrated security = True;");
            base.OnConfiguring(optionsBuilder);
        }
 
        public DbSet<Person>  people { get; set; }
    }
}
