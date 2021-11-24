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
