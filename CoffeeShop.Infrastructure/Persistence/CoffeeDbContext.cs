using Microsoft.EntityFrameworkCore;
using CoffeeShop.Infrastructure.Configuration;
using CoffeeShop.Application.Common.Entities.Mssql;

namespace CoffeeShop.Infrastructure.Persistence
{
    public class CoffeeDbContext : DbContext
    {
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options) : base(options) { }

        #region DbSet
        public virtual DbSet<UserEntity> Users { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
