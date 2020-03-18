using Entites;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EFData
{
    public class TeacherContext : DbContext
    {

        HistoryContext context = new HistoryContext();
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        //public DbQuery<> MyProperty { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var autienti = modelBuilder.Model.GetEntityTypes()
         .Where(p =>


      
         typeof(IAuditTable02).IsAssignableFrom(p.ClrType));

            foreach (var item in autienti)
            {
                modelBuilder.Entity(item.ClrType).Property<int>("InsertBy");
                modelBuilder.Entity(item.ClrType).Property<int>("UpdateBytBy");
                modelBuilder.Entity(item.ClrType).Property<DateTime>("Updatedate");
                modelBuilder.Entity(item.ClrType).Property<DateTime>("InsertDate");
            }


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=TeacherAudit;integrated security=true;");

        }

        public override int SaveChanges()
        {
            var Entities = ChangeTracker.Entries().Where(p =>
            typeof(Audittable).IsAssignableFrom(p.Entity.GetType()));



            foreach (var item in Entities)
            {
                var teacher = item.Entity as Teacher;
                var temp = item.Entity as Audittable;
                if (item.State == EntityState.Added)
                {

                    temp.InsertBy = 1;
                    temp.InsertTime = DateTime.Now;
                    temp.UpdateBy = 1;
                    temp.UpdateTime = DateTime.Now;
                }

                if (item.State == EntityState.Modified
                  )
                {
                    var Serlizerdata = JsonConvert.SerializeObject(item.Entity);

                    temp.UpdateBy = 2;
                    temp.UpdateTime = DateTime.Now;

                    context.DataChangeHistories.Add(

                        new DataChangeHistory
                        {
                            EntityId = teacher.TeacherId.ToString(),
                            EntityType = teacher.GetType().FullName,
                            RegsiterationDate = DateTime.Now,
                            SerilzeDate = Serlizerdata

                        }
                        );
                }
            }

            context.SaveChanges();
            return base.SaveChanges();
        }

    }
}
