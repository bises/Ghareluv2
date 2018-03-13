using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RegistrationPortal.Models
{
    public class RegistrationPortalContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RegistrationPortalContext() : base("name=RegistrationPortalContext")
        {
        }

        public System.Data.Entity.DbSet<RegistrationPortal.Models.Person> People { get; set; }

        public override int SaveChanges()
        {
            AddTimeStamp();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            AddTimeStamp();
            return base.SaveChangesAsync();
        }

        private void AddTimeStamp()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is EntityBase && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUsername = !string.IsNullOrEmpty(System.Web.HttpContext.Current?.User?.Identity?.Name)
                ? HttpContext.Current.User.Identity.Name
                : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((EntityBase)entity.Entity).DateCreated = DateTime.UtcNow;
                    ((EntityBase)entity.Entity).UserCreated = currentUsername;
                }

                ((EntityBase)entity.Entity).DateModified = DateTime.UtcNow;
                ((EntityBase)entity.Entity).UserModified = currentUsername;
            }
        }
    }
}
