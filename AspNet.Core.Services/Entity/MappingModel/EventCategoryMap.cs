using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public static class EventCategoryMap
    {
        public  static ModelBuilder MapEventCategory(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<EventCategory>();
            entity.ToTable("EventCategory");
            //entity.HasKey(k => new { k.CategoryCode });
            //entity.Property(p => p.CategoryCode).UseSqlServerIdentityColumn();
            return modelBuilder;
        }
    }
}
