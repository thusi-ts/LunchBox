using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBox.Shared
{
    public class ProductStoreLocation
    {
        public Store Store { get; set; }

        public int StoreId { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public decimal Price { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
    public class ProductStoreLocationImageEntityTypeConfiguration : IEntityTypeConfiguration<ProductStoreLocation>
    {
        public void Configure(EntityTypeBuilder<ProductStoreLocation> builder)
        {
            builder.HasKey(p => new { p.StoreId, p.LocationId, p.ProductId });
            builder.Property(p => p.Price).HasColumnType("decimal(10,2)");

            builder.HasOne(p => p.Store).WithMany(p => p.ProductStoreLocations)
            .HasForeignKey(p => p.StoreId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(o => o.Location).WithMany(p => p.ProductStoreLocations)
            .HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(o => o.Product).WithMany(p => p.ProductStoreLocations)
            .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }
}
