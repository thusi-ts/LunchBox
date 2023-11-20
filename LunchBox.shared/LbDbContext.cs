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

        /// <summary>
        /// ApplyConfigurationsFromAssembly Applies configuration from all IEntityTypeConfiguration<TEntity> /> instances that are defined in provided assembly.
        /// IEntityTypeConfiguration simply automatically look for all classes that implement IEntityTypeConfiguration and look for fluent Api configuration
        /// StoreImageEntityTypeConfiguration from Store class implemented by IEntityTypeConfiguration. StoreImageEntityTypeConfiguration invoked by IEntityTypeConfiguration automatically
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

    /// <summary>
    /// LunchBox.Shared is just a class library and dobn't have program.cs
    /// ContextFactory is neccessy if you have a class library and want to use EF uses for test purpose or 
    /// that is why you have to add this ContextFactory to look for your Database
    /// </summary>
    public class LbDbContextFactory : IDesignTimeDbContextFactory<LbDbContext>
    {
        public LbDbContext CreateDbContext(string[] args = null)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var optionsBuilder = new DbContextOptionsBuilder<LbDbContext>();
            optionsBuilder
                //.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole())) if you want to log it
                .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

            return new LbDbContext(optionsBuilder.Options);
        }
    }
}
