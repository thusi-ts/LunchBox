using LunchBox.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


//SqllocalDB.exe s MSSQLLocalDB, SqllocalDB.exe i MSSQLLocalDB

namespace LunchBox.Shared
{
    public class LbDbContext : DbContext
    {
        public LbDbContext(DbContextOptions<LbDbContext> options)
            : base(options)
        { 
        
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationsDelivery> LocationsDeliverys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderExtraItem> OrderExtraItems { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductExtraItem> ProductExtraItems { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<ProductStoreLocation> ProductStoreLocations { get; set; }
        public DbSet<StoresPaymentDetail> StoresPaymentDetails { get; set; }
        public DbSet<CartTemp> TempCarts { get; set; }
        public DbSet<CartTempExtraItem> TempCartExtraItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

    public class LbDbContextFactory : IDesignTimeDbContextFactory<LbDbContext>
    {
        public LbDbContext CreateDbContext(string[] args = null)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var optionsBuilder = new DbContextOptionsBuilder<LbDbContext>();
            optionsBuilder
                //.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

            return new LbDbContext(optionsBuilder.Options);
        }
    }
}
