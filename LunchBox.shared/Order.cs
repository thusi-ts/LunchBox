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
    public class Order
    {
        public int Id { get; set; } 

        public OrderMethodType OrderMethod { get; set; }

        public User IdentityUser { get; set; }

        public string UserId { get; set; }

        public String UserOrderNumber { get; set; }

        public String UserOrderNumberName { get; set; }
        
        public OrderStatusType OrderStatus { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public DateTime RequiredTime { get; set; }

        public DateTime ShippedTime { get; set; }

        public Store Store { get; set; }

        public int? StoreId { get; set; }

        public String Comments { get; set; }

        public ICollection<OrderExtraItem> OrderExtraItems { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases f
    /// </summary>
    public class OrderImageEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.UserOrderNumber).HasMaxLength(100);
            builder.Property(p => p.UserOrderNumberName).HasMaxLength(100);
            builder.Property(p => p.OrderStatus).HasConversion<string>();
            builder.Property(p => p.OrderMethod).HasConversion<string>();
            builder.Property(p => p.Comments).HasColumnType("nvarchar(max)");

            builder.HasOne(p => p.IdentityUser).WithMany(p => p.Orders)
            .HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.Store).WithMany(p => p.Orders)
            .HasForeignKey(p => p.StoreId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }

    public enum OrderMethodType
    {
        Levering = 1,
        Afhentning = 2
    }

    public enum OrderStatusType
    {
        Processing = 1,
        Completed = 2,
        Rejected = 3
    }
}