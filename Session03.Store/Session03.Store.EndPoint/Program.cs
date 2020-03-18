using static System.Console;
using System;
using Session03.Store.DAL;

namespace Session03.Store.EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx=new StoreDb())
            {
                var course = ctx.Courses.Find(1);
                course.Name = "ASP.NET Core MVC 3";
                ctx.SaveChanges();
            };


            WriteLine("Done");
            ReadLine();
        }

        private static void NewMethod(StoreDb ctx)
        {
            ctx.Courses.Add(new Domin.Course { Name = "Asp .Net Mvc" });
        }
    }
}
