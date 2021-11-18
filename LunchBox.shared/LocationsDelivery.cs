using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
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
