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
    public class Order
    {
        public int Id { get; set; }

        public OrderMethodType OrderMethod { get; set; }

        public User User { get; set; }

        public int UserId { get; set; } = 0;

        public String UserOrderNumber { get; set; }

        public String UserOrderNumberName { get; set; }
        
        public OrderStatusType OrderStatus { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public DateTime RequiredTime { get; set; }

        public DateTime ShippedTime { get; set; }

        public Store Strore { get; set; }

        public int StoreId { get; set; }

        public String Comments { get; set; }

        public ICollection<OrderExtraItem> OrderExtraItems { get; set; }
    }

    public class OrderImageEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.User).IsRequired();
            builder.Property(p => p.UserOrderNumber).HasMaxLength(100);
            builder.Property(p => p.UserOrderNumberName).HasMaxLength(100);
            builder.Property(p => p.OrderStatus).HasConversion<string>();
            builder.Property(p => p.OrderMethod).HasConversion<string>();
            builder.Property(p => p.Comments).HasColumnType("nvarchar(max)");
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