using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Entities
{
    public class CourseContext : DbContext
    {


        public DbSet<Course> Courses { get; set; }

        public DbSet<Teacher>  Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=CourseDB;integrated security=true;");
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasQueryFilter(c => c.Fired == false);
            base.OnModelCreating(modelBuilder); 
        }
    }
}
