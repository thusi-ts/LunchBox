using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBox.Shared
{
    public class LocationsDelivery
    {
        public Location Location { get; set; }

        public int LocationId { get; set; }

        public Store Store { get; set; }

        public int StoreId { get; set; }

        public String DeliveryTime { get; set; }

        public String OrderClosingTime { get; set; }

        public int Active { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
    public class LocationsDeliveryImageEntityTypeConfiguration : IEntityTypeConfiguration<LocationsDelivery>
    {
        public void Configure(EntityTypeBuilder<LocationsDelivery> builder)
        {
            builder.HasKey(p => new { p.LocationId, p.StoreId });
            builder.Property(p => p.DeliveryTime).HasMaxLength(200);
            builder.Property(p => p.OrderClosingTime).HasMaxLength(200);

            builder.HasOne(p => p.Location).WithMany(p => p.LocationsDeliverys)
            .HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(o => o.Store).WithMany(p => p.LocationsDeliverys)
            .HasForeignKey(p => p.StoreId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }
}
