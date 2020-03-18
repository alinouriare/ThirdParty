using EFData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StateMangment
{
    partial class Program
    {
        static void Main(string[] args)
        {
            TeacherContext teacherContext = new TeacherContext();
            //Query begirim
            //var tea = teacherContext.Teachers.FromSql("");

            //var rr = teacherContext.Database.GetDbConnection().ConnectionString;
            //command insert update 
            //teacherContext.Database.ExecuteSqlCommand("");

            //teacherContext.Teachers.Load();

            //var tan = teacherContext.Database.BeginTransaction();

            foreach (var item in teacherContext.Model.GetEntityTypes())
            {
                item.Name.Trim();
            }
            

        }

        private static void Tracker()
        {
            TeacherContext teacherContext = new TeacherContext();

            //teacherContext.Teachers.Add(new Entites.Teacher
            //{

            //    FirstName = "Omid",
            //    LastName = "Khaleghi"
            //});
            var a = teacherContext.Teachers.FirstOrDefault();
            a.LastName = "nouri arejani";

            teacherContext.SaveChanges();
            a.FirstName = "ALi";
            teacherContext.SaveChanges();

            System.Console.WriteLine("W");

            Console.ReadLine();
        }

    }
}
