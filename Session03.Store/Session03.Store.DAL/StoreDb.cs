using Microsoft.EntityFrameworkCore;
using Session03.Store.Domin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session03.Store.DAL
{
  public class StoreDb:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=Store;integrated security=true;");
         
        }


        public DbSet<Teacher> Teachers { get; set; }


        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }


        public DbSet<TeacherCourse>  TeacherCourses { get; set; }


        public DbSet<TeacherStudent>  TeacherStudents { get; set; }
    }
}
