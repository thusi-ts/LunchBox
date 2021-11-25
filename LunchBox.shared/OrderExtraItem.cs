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
    public class OrderExtraItem
    {
        public Order Order { get; set; }
        
        public int OrderId { get; set; }
        
        public Product Product { get; set; }

        public int ProductId { get; set; }

        public String ProductName { get; set; }
        
        public int Quantity { get; set; }
        
        public decimal Price { get; set; }
        
        public decimal Discount { get; set; }
        
        public decimal TotalPrice { get; set; }
        
        public ProductExtraItem ProductExtraItem { get; set; }

        public int? ProductExtraitemId { get; set; }
        
        public String ProductExtraitemName { get; set; }

        public String ProductExtraitemValue { get; set; }

        public decimal ProductExtraitemPrice { get; set; }
    }

    public class OrderExtraItemImageEntityTypeConfiguration : IEntityTypeConfiguration<OrderExtraItem>
    {
        public void Configure(EntityTypeBuilder<OrderExtraItem> builder)
        {
            builder.HasKey(p => new { p.OrderId, p.ProductId });
            builder.Property(p => p.ProductName).HasMaxLength(200);
            builder.Property(p => p.ProductExtraitemName).HasMaxLength(200);
            builder.Property(p => p.ProductExtraitemValue).HasMaxLength(200);

            builder.HasOne(o => o.Order).WithMany(o => o.OrderExtraItems)
            .HasForeignKey(p => p.OrderId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(o => o.Product).WithMany(p => p.OrderExtraItems)
            .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(o => o.ProductExtraItem).WithMany(px => px.OrderExtraItems)
            .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }

}
