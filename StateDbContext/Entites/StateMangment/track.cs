using EFData;
using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace StateMangment
{
    partial class Program
    {
        public class track
        {
            private static void TrackGraph()
            {
                var ctx = new PersonContext();
                var ctx2 = new PersonContext();
                var person = ctx2.People.Include(c => c.JobData).Include(c => c.Contacts).FirstOrDefault();

                ctx.ChangeTracker.TrackGraph(person, c =>
                {

                    switch (c.Entry.Entity)
                    {
                        case Person p:
                            ctx.Entry(person).State = EntityState.Unchanged;
                            Console.WriteLine("Person:" + p.PersonId);
                            break;
                        case JobData j:
                            Console.WriteLine("Person:" + j.JobDataId);
                            break;
                        case Contact cc:
                            Console.WriteLine("Person:" + cc.ContactId);
                            break;
                        default:
                            break;
                    }

                });
                Console.ReadLine();
            }

            private static void Ismodify(PersonContext ctx)
            {
                Person person = ctx.People.FirstOrDefault();
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine(ctx.Entry(person).Property(c => c.FirstName).IsModified);
                ctx.Entry(person).Property(c => c.FirstName).IsModified = true;
                Console.WriteLine(ctx.Entry(person).Property(c => c.FirstName).IsModified);

                Console.WriteLine("Person:" + ctx.Entry(person).State);
                ctx.SaveChanges();
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine(ctx.Entry(person).Property(c => c.FirstName).IsModified);
                Console.WriteLine("ok");
                Console.ReadLine();
            }

            private static void Upadte01(PersonContext ctx)
            {
                Person person = ctx.People.FirstOrDefault();
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                person.FirstName = "aa";
                ctx.People.Update(person);
                Console.WriteLine("JobData:" + ctx.Entry(person).State);
                Console.WriteLine("ok");
                Console.ReadLine();
            }

            private static void Remove02(PersonContext ctx)
            {
                Person person = ctx.People.FirstOrDefault();
                JobData jobData = new JobData
                {

                    JobTitle = "Developer"
                };
                person.JobData = jobData;
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");

                ctx.Remove(person);
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                ctx.SaveChanges();
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                Console.ReadLine();
            }

            private static void Remove01(PersonContext ctx)
            {
                Person person = ctx.People.FirstOrDefault();
                JobData jobData = new JobData
                {

                    JobTitle = "Developer"
                };
                //person.JobData = jobData;
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");

                ctx.Remove(person);
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                ctx.SaveChanges();
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                Console.ReadLine();
            }

            private static void Add03(PersonContext ctx)
            {
                Person person = ctx.People.FirstOrDefault();



                JobData jobData = new JobData
                {

                    JobTitle = "Developer"
                };


                person.JobData = jobData;
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                //ctx.Add(person);
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                ctx.SaveChanges();
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                Console.ReadLine();
            }

            private static void Add02(PersonContext ctx)
            {
                Person person = new Person
                {
                    FirstName = "Reza",
                    LastName = "Akbari",


                };

                JobData jobData = ctx.JobDatas.FirstOrDefault();


                person.JobData = jobData;
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                ctx.Add(person);
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                ctx.SaveChanges();
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                Console.ReadLine();
            }

            private static void Add01(PersonContext ctx)
            {
                Person person = new Person
                {
                    FirstName = "Ali",
                    LastName = "Nouri",


                };

                JobData jobData = new JobData
                {

                    JobTitle = "Developer"
                };

                person.JobData = jobData;
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                ctx.Add(person);
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                ctx.SaveChanges();
                Console.WriteLine("Person:" + ctx.Entry(person).State);
                Console.WriteLine("JobData:" + ctx.Entry(jobData).State);
                Console.WriteLine("ok");
                Console.ReadLine();
            }
        }

   
    }
}
