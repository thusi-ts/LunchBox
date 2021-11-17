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
    public class CartTemp
    {
        public int TempCartId { get; set; }

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
            builder.Property(p => p.SessionId).HasMaxLength(250);
            builder.Property(p => p.Comments).HasColumnType("nvarchar(max)");
        }        
    }
}
