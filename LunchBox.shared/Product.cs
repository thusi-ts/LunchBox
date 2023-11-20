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

        public int? StoreId { get; set; }

        public decimal Price { get; set; }
        
        public decimal Discount { get; set; }

        public String Picture { get; set; }

        public int Active { get; set; }

        public String ActiveOffMes { get; set; }
        
        public ProductExtraItem ProductExtraItem1 { get; set; }

        public int? ProductExtraitem1Id { get; set; }

        public int? ProductExtraitemMandatory1 { get; set; }
        
        public ProductExtraItem ProductExtraItem2 { get; set; }
        
        public int? ProductExtraitem2Id { get; set; }
        
        public int? ProductExtraitemMandatory2 { get; set; }

        public ProductExtraItem ProductExtraItem3 { get; set; }

        public int? ProductExtraitem3Id { get; set; }
        
        public int? ProductExtraitemMandatory3 { get; set; }

        public ProductExtraItem ProductExtraItem4 { get; set; }

        public int? ProductExtraitem4Id { get; set; }
        
        public int? ProductExtraitemMandatory4 { get; set; }

        public ProductExtraItem ProductExtraItem5 { get; set; }

        public int? ProductExtraitem5Id { get; set; }
        
        public int? ProductExtraitemMandatory5 { get; set; }

        public ProductExtraItem ProductExtraItem6 { get; set; }

        public int? ProductExtraitem6Id { get; set; }
        
        public int? ProductExtraitemMandatory6 { get; set; }

        public ProductExtraItem ProductExtraItem7 { get; set; }

        public int? ProductExtraitem7Id { get; set; }
        
        public int? ProductExtraitemMandatory7 { get; set; }

        public ProductExtraItem ProductExtraItem8 { get; set; }

        public int? ProductExtraitem8Id { get; set; }
        
        public int? ProductExtraitemMandatory8 { get; set; }

        public ProductExtraItem ProductExtraItem9 { get; set; }

        public int? ProductExtraitem9Id { get; set; }
        
        public int? ProductExtraitemMandatory9 { get; set; }

        public ProductExtraItem ProductExtraItem10 { get; set; }

        public int? ProductExtraitem10Id { get; set; }
        
        public int? ProductExtraitemMandatory10 { get; set; }

        public ICollection<OrderExtraItem> OrderExtraItems { get; set; }
        public ICollection<ProductStoreLocation> ProductStoreLocations { get; set; }
        public ICollection<CartTemp> TempCarts { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
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

            builder.HasData
            (
                new Product
                {
                    Id = 1,
                    ProductName = "kylling & Bacon",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 2,
                    ProductName = "kylling & Annanas",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Kylling & Jalepenos",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Kylling",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Skinke & Ost",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 6,
                    ProductName = "Æg & Rejer",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 7,
                    ProductName = "Tunsalat",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 8,
                    ProductName = "Koldrøget Laks",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 9,
                    ProductName = "Oksestrimler",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 10,
                    ProductName = "Pulled Pork",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 11,
                    ProductName = "Lufttørret Skinke",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 12,
                    ProductName = "Vegatar Falafel",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                },
                new Product
                {
                    Id = 13,
                    ProductName = "Mexikansk krydret oksekød",
                    ProductCategoryId = 1,
                    StoreId = null,
                    Price = 32.00m,
                    ProductExtraitem1Id = 1,
                    ProductExtraitemMandatory1 = 1,
                    ProductExtraitem2Id = 2,
                    ProductExtraitemMandatory2 = 1,
                    ProductExtraitem3Id = 3,
                    ProductExtraitemMandatory3 = null,
                    ProductExtraitem4Id = 4,
                    ProductExtraitemMandatory4 = null,
                }
            );
        }
    }
}
