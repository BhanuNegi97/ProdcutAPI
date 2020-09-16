using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAPI.Model;
using Microsoft.EntityFrameworkCore;
using Polly;

namespace ProductAPI.DataAccess
{
    public class ProductAPIDBContext : DbContext
    {
        public ProductAPIDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasKey(m => m.productId);
            builder.Entity<Product>().ToTable("Product");
            base.OnModelCreating(builder);
        }

        public void MigrateDB()
        {
                Policy.Handle<Exception>()
                .WaitAndRetry(10, r => TimeSpan.FromSeconds(10))
                .Execute(() => Database.Migrate());
        }

    }
}
