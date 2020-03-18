using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFData
{
   public class PersonContext:DbContext
    {

        public DbSet<Person> People { get; set; }
        public DbSet<JobData> JobDatas { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=PersonState;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>().HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangedNotifications);
        }
    }
}
