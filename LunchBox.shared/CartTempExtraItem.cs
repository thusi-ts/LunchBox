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
    public class CartTempExtraItem
    {
        public int TempCartId { get; set; }
        
        public ProductExtraItem ProductExtraItem { get; set; }

        public int ProductExtraItemId { get; set; }
        
        public String ProductExtraItemName { get; set; }

        public String ProductExtraItemValue { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
    public class CartTempExtraItemImageEntityTypeConfiguration : IEntityTypeConfiguration<CartTempExtraItem>
    {
        public void Configure(EntityTypeBuilder<CartTempExtraItem> builder)
        {
            builder.HasKey(p => p.TempCartId);
            builder.Property(p => p.ProductExtraItemName).HasMaxLength(250);
            builder.Property(p => p.ProductExtraItemValue).HasMaxLength(250);

            builder.HasOne(p => p.ProductExtraItem).WithMany(p => p.TempCartExtraItems)
            .HasForeignKey(p => p.ProductExtraItemId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }
}

