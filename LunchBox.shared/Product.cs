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
    public class Product
    {
        public int Id { get; set; }

        public String ProductName { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public int ProductCategoryId { get; set; }
        
        public Store Store { get; set; }

        public int StoreId { get; set; }

        public decimal Price { get; set; }
        
        public decimal Discount { get; set; }

        public String Picture { get; set; }

        public int Active { get; set; } = 1;

        public String ActiveOffMes { get; set; }
        
        public ProductExtraItem ProductExtraItem1 { get; set; }

        public int? ProductExtraitem1Id { get; set; }

        public int ProductExtraitemMandatory1 { get; set; }
        
        public ProductExtraItem ProductExtraItem2 { get; set; }
        
        public int? ProductExtraitem2Id { get; set; }
        
        public int ProductExtraitemMandatory2 { get; set; }

        public ProductExtraItem ProductExtraItem3 { get; set; }

        public int? ProductExtraitem3Id { get; set; }
        
        public int ProductExtraitemMandatory3 { get; set; }

        public ProductExtraItem ProductExtraItem4 { get; set; }

        public int? ProductExtraitem4Id { get; set; }
        
        public int ProductExtraitemMandatory4 { get; set; }

        public ProductExtraItem ProductExtraItem5 { get; set; }

        public int? ProductExtraitem5Id { get; set; }
        
        public int ProductExtraitemMandatory5 { get; set; }

        public ProductExtraItem ProductExtraItem6 { get; set; }

        public int? ProductExtraitem6Id { get; set; }
        
        public int ProductExtraitemMandatory6 { get; set; }

        public ProductExtraItem ProductExtraItem7 { get; set; }

        public int? ProductExtraitem7Id { get; set; }
        
        public int ProductExtraitemMandatory7 { get; set; }

        public ProductExtraItem ProductExtraItem8 { get; set; }

        public int? ProductExtraitem8Id { get; set; }
        
        public int ProductExtraitemMandatory8 { get; set; }

        public ProductExtraItem ProductExtraItem9 { get; set; }

        public int? ProductExtraitem9Id { get; set; }
        
        public int ProductExtraitemMandatory9 { get; set; }

        public ProductExtraItem ProductExtraItem10 { get; set; }

        public int? ProductExtraitem10Id { get; set; }
        
        public int ProductExtraitemMandatory10 { get; set; }

        public ICollection<OrderExtraItem> OrderExtraItems { get; set; }
        public ICollection<ProductStoreLocation> ProductStoreLocations { get; set; }
        public ICollection<CartTemp> TempCarts { get; set; }
    }

    public class ProductImageEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProductName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Picture).HasMaxLength(200);
            builder.Property(p => p.ActiveOffMes).HasColumnType("nvarchar(max)");
            builder.Property(p => p.Discount).HasColumnType("decimal(10,2)");
            builder.Property(p => p.Price).HasColumnType("decimal(10,2)");

            builder.HasOne(p => p.ProductExtraItem1).WithMany(pe => pe.Products1)
           .HasForeignKey(p => p.ProductExtraitem1Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.ProductExtraItem3).WithMany(pe => pe.Products2)
           .HasForeignKey(p => p.ProductExtraitem3Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.ProductExtraItem4).WithMany(pe => pe.Products3)
           .HasForeignKey(p => p.ProductExtraitem4Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.ProductExtraItem5).WithMany(pe => pe.Products4)
           .HasForeignKey(p => p.ProductExtraitem5Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.ProductExtraItem6).WithMany(pe => pe.Products5)
           .HasForeignKey(p => p.ProductExtraitem6Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.ProductExtraItem7).WithMany(pe => pe.Products6)
           .HasForeignKey(p => p.ProductExtraitem7Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.ProductExtraItem8).WithMany(pe => pe.Products7)
           .HasForeignKey(p => p.ProductExtraitem8Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.ProductExtraItem9).WithMany(pe => pe.Products8)
           .HasForeignKey(p => p.ProductExtraitem9Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            builder.HasOne(p => p.ProductExtraItem10).WithMany(pe => pe.Products10)
           .HasForeignKey(p => p.ProductExtraitem10Id).OnDelete(DeleteBehavior.Restrict).IsRequired(false);


            builder.HasOne(p => p.Store).WithMany(s => s.Products)
           .HasForeignKey(p => p.StoreId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            builder.HasOne(p => p.ProductCategory).WithMany(pc => pc.Products)
           .HasForeignKey(p => p.ProductCategoryId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }
}
