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
    class LbDbContext : DbContext
    {
        public LbDbContext(DbContextOptions<LbDbContext> options)
            : base(options)
        { 
        
        }
        //public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public class LbDbContextFactory : IDesignTimeDbContextFactory<LbDbContext>
        {
            public LbDbContext CreateDbContext(string[]? args = null)
            {
                var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                var optionsBuilder = new DbContextOptionsBuilder<LbDbContext>();
                optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

                return new LbDbContext(optionsBuilder.Options);
            }
        }

    }
}
