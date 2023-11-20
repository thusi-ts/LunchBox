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
    public class ProductExtraItem
    {
        public int Id { get; set; }

        public String MachineName { get; set; }

        public String Name { get; set; }

        public Store Store { get; set; }

        public int? StoreId { get; set; }

        public String ItemName1 { get; set; }
        
        public decimal ItemPrice1 { get; set; }

        public String ItemName2 { get; set; }
        
        public decimal ItemPrice2 { get; set; }

        public String ItemName3 { get; set; }
        
        public decimal ItemPrice3 { get; set; }

         public String ItemName4 { get; set; }
        
        public decimal ItemPrice4 { get; set; }

        public String ItemName5 { get; set; }
       
        public decimal ItemPrice5 { get; set; }

        public String ItemName6 { get; set; }
        
        public decimal ItemPrice6 { get; set; }

        public String ItemName7 { get; set; }
        
        public decimal ItemPrice7 { get; set; }

        public String ItemName8 { get; set; }
        
        public decimal ItemPrice8 { get; set; }

        public String ItemName9 { get; set; }
        
        public decimal ItemPrice9 { get; set; }

        public String ItemName10 { get; set; }
        
        public decimal ItemPrice10 { get; set; }

        public String ItemName11 { get; set; }
        
        public decimal ItemPrice11 { get; set; }

        public String ItemName12 { get; set; }
        
        public decimal ItemPrice12 { get; set; }

        public String ItemName13 { get; set; }
        
        public decimal ItemPrice13 { get; set; }

        public String ItemName14 { get; set; }
        
        public decimal ItemPrice14 { get; set; }

        public String ItemName15 { get; set; }
        
        public decimal ItemPrice15 { get; set; }

        public String ItemName16 { get; set; }
        
        public decimal ItemPrice16 { get; set; }

        public String ItemName17 { get; set; }
        
        public decimal ItemPrice17 { get; set; }

        public String ItemName18 { get; set; }
        
        public decimal ItemPrice18 { get; set; }

        public String ItemName19 { get; set; }
        
        public decimal ItemPrice19 { get; set; }

        public String ItemName20 { get; set; }
        
        public decimal ItemPrice20 { get; set; }

        public ICollection<OrderExtraItem> OrderExtraItems { get; set; }
        public ICollection<CartTempExtraItem> TempCartExtraItems { get; set; }
        public ICollection<Product> Products1 { get; set; }
        public ICollection<Product> Products2 { get; set; }
        public ICollection<Product> Products3 { get; set; }
        public ICollection<Product> Products4 { get; set; }
        public ICollection<Product> Products5 { get; set; }
        public ICollection<Product> Products6 { get; set; }
        public ICollection<Product> Products7 { get; set; }
        public ICollection<Product> Products8 { get; set; }
        public ICollection<Product> Products9 { get; set; }
        public ICollection<Product> Products10 { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
    public class ProductExtraItemImageEntityTypeConfiguration : IEntityTypeConfiguration<ProductExtraItem>
    {
        public void Configure(EntityTypeBuilder<ProductExtraItem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(250);
            builder.Property(p => p.ItemName1).HasMaxLength(250);
            builder.Property(p => p.ItemName2).HasMaxLength(250);
            builder.Property(p => p.ItemName3).HasMaxLength(250);
            builder.Property(p => p.ItemName4).HasMaxLength(250);
            builder.Property(p => p.ItemName5).HasMaxLength(250);
            builder.Property(p => p.ItemName6).HasMaxLength(250);
            builder.Property(p => p.ItemName7).HasMaxLength(250);
            builder.Property(p => p.ItemName8).HasMaxLength(250);
            builder.Property(p => p.ItemName9).HasMaxLength(250);
            builder.Property(p => p.ItemName10).HasMaxLength(250);
            builder.Property(p => p.ItemName11).HasMaxLength(250);
            builder.Property(p => p.ItemName12).HasMaxLength(250);
            builder.Property(p => p.ItemName13).HasMaxLength(250);
            builder.Property(p => p.ItemName14).HasMaxLength(250);
            builder.Property(p => p.ItemName15).HasMaxLength(250);
            builder.Property(p => p.ItemName16).HasMaxLength(250);
            builder.Property(p => p.ItemName17).HasMaxLength(250);
            builder.Property(p => p.ItemName18).HasMaxLength(250);
            builder.Property(p => p.ItemName19).HasMaxLength(250);
            builder.Property(p => p.ItemName20).HasMaxLength(250);

            builder.Property(b => b.ItemPrice1).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice2).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice3).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice4).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice5).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice6).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice7).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice8).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice9).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice10).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice11).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice12).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice13).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice14).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice15).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice16).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice17).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice18).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice19).HasColumnType("decimal(5, 2)");
            builder.Property(b => b.ItemPrice20).HasColumnType("decimal(5, 2)");

            builder.HasData
            (
                new ProductExtraItem
                {
                    Id = 1, 
                    MachineName = "bread", 
                    StoreId = null, 
                    Name = "Brød", 
                    ItemName1 = "Lys", 
                    ItemPrice1 = 0
                },
                new ProductExtraItem
                {
                    Id = 2, 
                    MachineName = "saurce", 
                    StoreId = null, 
                    Name = "Dressing", 
                    ItemName1 = "Karry",
                    ItemName2 = "Creme fraiche",
                    ItemName3 = "Chili",
                    ItemName4 = "Hvidløg",
                    ItemName5 = "Thousand Island",
                    ItemName6 = "Mexikansk",
                    ItemName7 = "Grøn pesto",
                    ItemName8 = "BBQ sauce",
                    ItemName9 = "Senneps dild",
                    ItemName10 = "Ingen dressing",
                },

                new ProductExtraItem
                {
                    Id = 3,
                    MachineName = "pep",
                    StoreId = null,
                    Name = "Ekstra fyld",
                    ItemName1 = "Ananas",
                    ItemPrice1 = 5.00m,
                    ItemName2 = "Bacon",
                    ItemPrice2 = 5.00m,
                    ItemName3 = "Jalapenios",
                    ItemPrice3 = 5.00m,
                    ItemName4 = "Kylling",
                    ItemPrice4 = 5.00m,
                    ItemName5 = "Ost",
                    ItemPrice5 = 5.00m,
                    ItemName6 = "Rejer",
                    ItemPrice6 = 5.00m,
                    ItemName7 = "Rødløg",
                    ItemPrice7 = 5.00m,
                    ItemName8 = "Tun",
                    ItemPrice8 = 5.00m,
                    ItemName9 = "Tzatziki",
                    ItemPrice9 = 5.00m,
                    ItemName10 = "Cheddar ost",
                    ItemPrice10 = 5.00m,
                },

                new ProductExtraItem
                {
                    Id = 4,
                    MachineName = "menu_drinks",
                    StoreId = null,
                    Name = "Menutilbud",
                    ItemName1 = "Dåsesodavand",
                    ItemPrice1 = 10.00m,
                }
            );
        }
    }
}
