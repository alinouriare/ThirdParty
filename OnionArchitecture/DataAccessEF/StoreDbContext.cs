using Entities.Courses;
using Entities.Students;
using Entities.Teachers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessEF
{

    public class DbContextFactory : IDesignTimeDbContextFactory<StoreDbContext>
    {
        public StoreDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<StoreDbContext> optionBuilder = new DbContextOptionsBuilder<StoreDbContext>();
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=DBStore;integrated security=true;");

            return new StoreDbContext(optionBuilder.Options);

            //dbContext.Database.EnsureCreated();
        }
    }
    public class StoreDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }


        public DbSet<Student> Students { get; set; }

        public DbSet<TeacherCourse> TeacherCourses { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }


        public DbQuery<CourseVm> courseVms { get; set; }


        public StoreDbContext(DbContextOptions<StoreDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Query<CourseVm>().ToView("Course_Vm");
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
