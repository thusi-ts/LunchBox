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
    public class CartTemp
    {
        public int Id { get; set; }

        public String SessionId { get; set; }

        public DateTime ModifiedTime { get; set; } = DateTime.Now;

        public Store Store { get; set; }

        public int StoreId { get; set; }
        
        public Product Product { get; set; }

        public int ProductId { get; set; }
        
        public int Quantity { get; set; }

        public int Comments { get; set; }

        public ICollection<CartTempExtraItem> TempCartExtraItems { get; set; }
    }

    public class CartTempImageEntityTypeConfiguration : IEntityTypeConfiguration<CartTemp>
    {
        public void Configure(EntityTypeBuilder<CartTemp> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.SessionId).HasMaxLength(250);
            builder.Property(p => p.Comments).HasColumnType("nvarchar(max)");

            builder.HasOne(p => p.Store).WithMany(p => p.TempCarts)
            .HasForeignKey(p => p.StoreId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.Product).WithMany(p => p.TempCarts)
            .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }        
    }
}
