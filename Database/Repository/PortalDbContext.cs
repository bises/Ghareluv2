using Database.Models;
using System.Configuration;
using System.Data.Entity;
using System;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Database.Repository
{
    public class PortalDbContext : DbContext
    {
        public PortalDbContext() : base(ConfigurationManager.ConnectionStrings["PortalDbContext"].ConnectionString) { }

        public DbSet<Person> Persons { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<UdhyogType> UdhyogTypes { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Address> Addresses { get; set; }

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
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedDate = DateTime.UtcNow;
                    ((BaseEntity)entity.Entity).CreatedByUserId = 1;
                }

                ((BaseEntity)entity.Entity).LastUpdateDate = DateTime.UtcNow;
                ((BaseEntity)entity.Entity).LastUpdateBy = 1;
            }

        }


    }
}