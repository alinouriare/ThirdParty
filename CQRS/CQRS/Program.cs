using CQRS.Infrastructures;
using Microsoft.EntityFrameworkCore;
using System;

namespace CQRS
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionBuliderWrite = new DbContextOptionsBuilder<PersonContext>();
            optionBuliderWrite.UseSqlServer(
                
                @"Server=(localdb)\mssqllocaldb;initial catalog=CQRSWrite;integrated security=true;"
                );


            var optionBuliderRead = new DbContextOptionsBuilder<PersonContext>();
            optionBuliderRead.UseSqlServer(

                @"Server=(localdb)\mssqllocaldb;initial catalog=CQRSRead;integrated security=true;"
                );

            var contextWrite = new PersonContext(optionBuliderWrite.Options);
            var contextRead = new PersonContext(optionBuliderRead.Options);





            //context.Database.EnsureCreated();


            var ReadRep = new PersonReadRepository(contextRead.Database.GetDbConnection().ConnectionString);
            var WriteRep = new PersonWriteRepository(contextWrite);




        //    WriteRep.Add(new Entities.Person {
            
        //FirstName="Reza",
        //LastName="Akbari"

            
        //    });

            var list = ReadRep.GetAll();

            foreach (var item in list)
            {
                Console.WriteLine(string.Format($"Name{item.FirstName}"+" " + $"Name{item.LastName}"));
            }
            Console.ReadKey();
        }
    }
}
