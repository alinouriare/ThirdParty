using EntityFrameworkExtention.Extentions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EntityFrameworkExtention.Abstractions
{
    public abstract class BaseDbcontext : DbContext
    {

        public override int SaveChanges()
        {
            BeforSave();
            var result = base.SaveChanges();
            AfterSave();
            return result;
        }

        private void AfterSave()
        {
          
        }

        private void BeforSave()
        {
            SetYeKe();
        }

        private void SetYeKe()
        {
            var addOrUpdate = this.GetAddOrModifiedEntities();
            foreach (var item in addOrUpdate)
            {
                var entity = item.Entity;
                if (item.Entity !=null)
                {
                    continue;
                }

                var propertyInfos = entity.GetType().GetProperties(

                    BindingFlags.Public | BindingFlags.Instance).Where(

                    p => p.CanWrite && p.CanRead && p.PropertyType == typeof(string));

                foreach (var propertInfo in propertyInfos)
                {
                    var propName = propertInfo.Name;
                    var value = propertInfo.GetValue(entity);
                    if (value !=null)
                    {
                        var strValue = value.ToString();
                        var newValue = strValue.SetPersianYeKe();
                        if (newValue !=null)
                        {
                            propertInfo.SetValue(entity, newValue);
                        }
                    }
                }
            }

        }
    }
}
