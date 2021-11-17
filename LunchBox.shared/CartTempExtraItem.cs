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
    public class CartTempExtraItem
    {
        public int TempCartId { get; set; }
        
        public ProductExtraItem ProductExtraItem { get; set; }

        public int ProductExtraItemId { get; set; }
        
        public String ProductExtraItemName { get; set; }

        public String ProductExtraItemValue { get; set; }
    }

    public class CartTempExtraItemImageEntityTypeConfiguration : IEntityTypeConfiguration<CartTempExtraItem>
    {
        public void Configure(EntityTypeBuilder<CartTempExtraItem> builder)
        {
            builder.HasKey(p => p.TempCartId);
            builder.Property(p => p.ProductExtraItemName).HasMaxLength(250);
            builder.Property(p => p.ProductExtraItemValue).HasMaxLength(250);
        }
    }
}

