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
    public class ProductCategory
    {
        public int Id { get; set; }

        public String CategoryName { get; set; }

        public String ImageFolder { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
    public class ProductCategoryImageEntityTypeConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CategoryName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.ImageFolder).HasMaxLength(200);

            builder.HasData
            (
                new ProductCategory
                {
                    Id = 1,
                    CategoryName = "Sandwich",
                    ImageFolder = null
                },
                new ProductCategory
                {
                    Id = 2,
                    CategoryName = "Salat",
                    ImageFolder = null
                },
                new ProductCategory
                {
                    Id = 3,
                    CategoryName = "Drikkevarer",
                    ImageFolder = null
                }
            );
        }
    }
}