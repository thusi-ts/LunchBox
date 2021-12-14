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