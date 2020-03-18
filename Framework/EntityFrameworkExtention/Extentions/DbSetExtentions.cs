using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExtention.Extentions
{
    public static class DbSetExtentions
    {
        public static DbContext GetDbContext<TEntity>(this DbSet<TEntity> dbSet)
            where TEntity:class
        {
            var infrastructure = dbSet as IInfrastructure<IServiceProvider>;
            var serviceProvider = infrastructure.Instance;
            var curentDbContext = serviceProvider.GetService(typeof(ICurrentDbContext)) as
                ICurrentDbContext;
            return curentDbContext.Context;
        }



        public static int Clear<TEntity>(this DbSet<TEntity> dbSet) where TEntity:class
        {

            var dbContext = dbSet.GetDbContext();
            var relationType = dbContext.Model.FindEntityType(typeof(TEntity));
            var schema = string.IsNullOrEmpty(relationType.GetSchema()) ? "dbo" : relationType.GetSchema();
            var tableName = string.IsNullOrEmpty(relationType.Name) ? typeof(TEntity).Name : relationType.Name;
            string deleteCommand = $"Delete {schema}.{tableName}";
            var result = dbContext.Database.ExecuteSqlCommand(deleteCommand);
            return result;
        }
    }
}
