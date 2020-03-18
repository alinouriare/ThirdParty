using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkExtention.Extentions
{
   public static class DbContextExtentions
    {

        public static int Clear<TEntity>(this DbContext dbContext) where TEntity:class
        {

            return dbContext.ContainsEntity<TEntity>() ? dbContext.Set<TEntity>().Clear() : 0;
        }


        public static bool ContainsEntity<TEntity>(this DbContext dbContext)
            where TEntity : class
        {
            return dbContext.Model.FindEntityType(typeof(TEntity)) != null;

        }


        public static IEnumerable<EntityEntry> GetChangedEntities(this DbContext dbContext,
            EntityState? entityState=null)
        {
            var entrise = dbContext.ChangeTracker.Entries();
            if (entityState.HasValue)
                entrise = entrise.Where(c => c.State == entityState.Value);
            return entrise;


        }


        public static IEnumerable<EntityEntry> GetAddOrModifiedEntities(this DbContext dbContext)
        {

            var entrise = dbContext.GetChangedEntities().Where(p => p.State == EntityState.Added ||
              p.State == EntityState.Modified);
            return entrise;
        }

        public static IEnumerable<EntityEntry> GetAddEntities(this DbContext dbContext)
        {

            var entrise = dbContext.GetChangedEntities().Where(p => p.State == EntityState.Added 
             );
            return entrise;
        }

        public static IEnumerable<EntityEntry> GetModifiedEntities(this DbContext dbContext)
        {

            var entrise = dbContext.GetChangedEntities().Where(p => p.State == EntityState.Modified
             );
            return entrise;
        }
        public static IEnumerable<EntityEntry> GetDeletedEntities(this DbContext dbContext)
        {

            var entrise = dbContext.GetChangedEntities().Where(p => p.State == EntityState.Deleted
             );
            return entrise;
        }
    }
}
