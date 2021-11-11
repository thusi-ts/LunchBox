using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ts_store.Models
{
    public class StoreDBContext:DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options):base(options) { 
        
        }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
