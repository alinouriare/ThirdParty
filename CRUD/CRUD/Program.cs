using CRUD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new CourseContext())
            {
            
                var teacher = ctx.Teachers.IgnoreQueryFilters().ToList();
                foreach (var item in teacher)
                {

                    Console.WriteLine(item.Name);
                   
                }
                Console.ReadKey();
            }
        }

        private static void Delete(CourseContext ctx)
        {
            var teacher = new Teacher
            {
                TeacherId = 4,
            };
            Console.WriteLine(ctx.Entry(teacher).State);
            Console.ReadLine();

            ctx.Teachers.Remove(teacher);
            Console.WriteLine(ctx.Entry(teacher).State);
            Console.ReadLine();
            ctx.SaveChanges();
            Console.WriteLine(ctx.Entry(teacher).State);
            Console.ReadLine();
        }

        private static void UpdateDesconcted02(int id, string name)
        {
            using (var ctx = new CourseContext())
            {

                var techer1 = ctx.Teachers.Find(id);
                Console.WriteLine(ctx.Entry(techer1).State);
                Console.ReadLine();
                techer1.Name = name;
                Console.WriteLine(ctx.Entry(techer1).State);
                Console.ReadLine();
                ctx.SaveChanges();
                Console.WriteLine(ctx.Entry(techer1).State);
                Console.ReadLine();

            }
        }

        private static void UpdateDesconcted01(Teacher techer1)
        {
            techer1.Name = $"{techer1.Name}{DateTime.Now}";


            using (var ctx = new CourseContext())
            {

                Console.WriteLine(ctx.Entry(techer1).State);
                Console.ReadLine();
                //EF Old
                //ctx.Entry(techer1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.Teachers.Update(techer1);

                Console.WriteLine(ctx.Entry(techer1).State);
                Console.ReadLine();

                ctx.SaveChanges();
                Console.WriteLine(ctx.Entry(techer1).State);
                Console.ReadLine();
            }
        }

        private static void UpadteConcted(CourseContext ctx)
        {
            //Prformance First Search in Context 
            var techer1 = ctx.Teachers.Find(3);
            ////Top 1 Select Sql
            //var techer2 = ctx.Teachers.FirstOrDefault(c => c.TeacherId == 3);
            ////Top 2 select Sql
            //var techer3 = ctx.Teachers.SingleOrDefault(c => c.TeacherId == 3);

            Console.WriteLine(ctx.Entry(techer1).State);
            Console.ReadLine();

            techer1.Name = "Hamid Beiglo";


            Console.WriteLine(ctx.Entry(techer1).State);
            Console.ReadLine();
            ctx.SaveChanges();
            Console.WriteLine(ctx.Entry(techer1).State);
            Console.ReadLine();
        }

        private static void Add(CourseContext ctx)
        {

            ctx.Database.EnsureCreated();
            Teacher t = new Teacher
            {

                Name = "RezaAkbari",


            };

            t.Courses.Add(new Course { Name = "SQL SERVER2019" });



            Console.WriteLine(ctx.Entry(t).State);
            Console.ReadLine();


            //ctx.Add(t);
            ctx.Teachers.Add(t);
            Console.WriteLine(ctx.Entry(t).State);

            Console.ReadLine();


            ctx.SaveChanges();
            Console.WriteLine(ctx.Entry(t).State);

            Console.ReadLine();
        }
    }
}
