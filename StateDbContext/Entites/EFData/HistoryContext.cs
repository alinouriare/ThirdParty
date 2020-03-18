using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFData
{
   public class HistoryContext:DbContext
    {

        public DbSet<DataChangeHistory>    DataChangeHistories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=HistoryDb;integrated security=true;");
        }
    }
}
