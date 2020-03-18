using DataAccessEF;
using Entities.Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Linq;

namespace EndPoints
{
    class Program
    {

        public static readonly ILoggerFactory MyLoggerFactory
       = LoggerFactory.Create(builder =>
       {
           builder
            .AddFilter((category, level) =>
                category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information)
            .AddConsole();
       });



        static void Main(string[] args)
        {

            DbContextOptionsBuilder<StoreDbContext> optionBuilder = new DbContextOptionsBuilder<StoreDbContext>();
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=DBStore;integrated security=true;");
            optionBuilder.UseLazyLoadingProxies();
            optionBuilder.UseLoggerFactory(MyLoggerFactory);

            var dbContext = new StoreDbContext(optionBuilder.Options);

            var course = dbContext.Courses.First();
            var teacher = course.Teachers;

            Console.WriteLine($"{ course.CourseId}{course.Name}");
        

        }

        private static void QueryType(StoreDbContext dbContext)
        {
            //var result = dbContext.courseVms.Where();
            dbContext.courseVms.FromSqlRaw("Select Name From Courses");
        }

        private static void DtoTest(StoreDbContext dbContext)
        {
            var result = dbContext.Courses.Select(c => new CourseDto
            {
                Name = c.Name,
                Id = c.CourseId
            });
        }

        private static void LazyLoding(StoreDbContext dbContext)
        {
            var course = dbContext.Courses.First();
            var teacher = course.Teachers;

            Console.WriteLine($"{ course.CourseId}{course.Name}");
        }

        private static void ExplicitRefrence(StoreDbContext dbContext)
        {
            var teachercourse = dbContext.TeacherCourses.First();
            dbContext.Entry(teachercourse).Reference(c => c.Teacher).Load();
        }

        private static void SelectLoding(StoreDbContext dbContext)
        {
            var item = dbContext.Courses.Select(c => new
            {
                c.Name,
                c.StartDate,

            });
        }

        private static void ExplicitLoading(StoreDbContext dbContext)
        {
            var course = dbContext.Courses.First();
            dbContext.Entry(course).Collection(c => c.Teachers).Load();
            //.Query()
            //.Where(c=>c.Teacher.FirstName.StartsWith("A"));
            Console.WriteLine($"{ course.CourseId}{course.Name}");
            Console.ReadKey();
        }

        private static void EagerLoding(StoreDbContext dbContext)
        {
            var courses = dbContext.Courses.Include(c => c.Teachers)
                .ThenInclude(c => c.Teacher).First();




            //foreach (var item in courses)
            //{
            Console.WriteLine($"{ courses.CourseId}{courses.Name}");
            //}
        }
    }
}
