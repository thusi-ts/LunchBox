using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBox.Shared
{
    public class Location
    {
        public int Id { get; set; }

        public String LocationName { get; set; }

        public String Phone { get; set; }

        public String Email { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public String Logo { get; set; }

        public String Picture { get; set; }

        public String ZipCode { get; set; }

        public String Cvr { get; set; }

        public String ContactPersonName { get; set; }

        public String ContactPersonEmail { get; set; }

        public String Map { get; set; }

        public String Description { get; set; }

        public int Active { get; set; }

        public String ActiveOffMes { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public ICollection<LocationsDelivery> LocationsDeliverys { get; set; }
        public ICollection<ProductStoreLocation> ProductStoreLocations { get; set; }
        public ICollection<User> Users { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
    public class LocationImageEntityTypeConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(p => p.LocationName).HasColumnName("Location name").HasMaxLength(150).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Street).HasMaxLength(100).IsRequired();
            builder.Property(p => p.City).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Logo).HasMaxLength(100);
            builder.Property(p => p.Picture).HasMaxLength(150);
            builder.Property(p => p.ZipCode).HasMaxLength(5);
            builder.Property(p => p.Cvr).HasMaxLength(10);
            builder.Property(p => p.ContactPersonEmail).HasMaxLength(100);
            builder.Property(p => p.Map).HasMaxLength(250);
            builder.Property(p => p.Description).HasColumnType("nvarchar(max)");
            builder.Property(p => p.ActiveOffMes).HasColumnType("nvarchar(max)");

            builder.HasData
            (
                new Location
                {
                    Id = 1,
                    Active = 1,
                    ActiveOffMes = "",
                    City = "Viborg", 
                    ContactPersonEmail = "email",
                    ContactPersonName = "name",
                    Cvr = "12133",
                    Description = "description",
                    Email = "email",
                    LocationName = "Midtbyen gymnasium",
                    ZipCode = "code",
                    Phone = "23465656", 
                    Street = ""
                }
            );
        }
    }
}

