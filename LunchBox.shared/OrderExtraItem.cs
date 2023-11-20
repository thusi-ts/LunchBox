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
        
        public int? OrderId { get; set; }
        
        public Product Product { get; set; }

        public int? ProductId { get; set; }

        public String ProductName { get; set; }
        
        public int? Quantity { get; set; }
        
        public Decimal Price { get; set; }
        
        public Decimal Discount { get; set; }
        
        public Decimal TotalPrice { get; set; }
        
        public ProductExtraItem ProductExtraItem { get; set; }

        public int? ProductExtraitemId { get; set; }
        
        public String ProductExtraitemName { get; set; }

        public String ProductExtraitemValue { get; set; }

        public Decimal ProductExtraitemPrice { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
    public class OrderExtraItemImageEntityTypeConfiguration : IEntityTypeConfiguration<OrderExtraItem>
    {
        public void Configure(EntityTypeBuilder<OrderExtraItem> builder)
        {
            builder.HasKey(p => new { p.OrderId, p.ProductId });
            builder.Property(p => p.ProductName).HasMaxLength(200);
            builder.Property(p => p.ProductExtraitemName).HasMaxLength(200);
            builder.Property(p => p.ProductExtraitemValue).HasMaxLength(200);
            builder.Property(p => p.Discount).HasColumnType("decimal(5, 2)");
            builder.Property(p => p.Price).HasColumnType("decimal(5, 2)");
            builder.Property(p => p.ProductExtraitemPrice).HasColumnType("decimal(5, 2)");
            builder.Property(p => p.TotalPrice).HasColumnType("decimal(5, 2)");

            builder.HasOne(o => o.Order).WithMany(o => o.OrderExtraItems)
            .HasForeignKey(p => p.OrderId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(o => o.Product).WithMany(p => p.OrderExtraItems)
            .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(o => o.ProductExtraItem).WithMany(px => px.OrderExtraItems)
            .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }

}
