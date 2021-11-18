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
    public class User
    {

        public int Id { get; set; }

        public String Fullname { get; set; }

        public String Phone { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public String ZipCode { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        public int Active { get; set; } = 1;

        public String Role { get; set; }

        public int Newsletter { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public DateTime EnteredTime { get; set; }

        public DateTime LastModifiedTime { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        public String PrimaryStoreIds { get; set; }

        public string Token { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

    public class UserImageEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(p => p.Fullname).HasColumnName("Full Name").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(100);
            builder.Property(p => p.Street).HasMaxLength(100);
            builder.Property(p => p.City).HasMaxLength(100);
            builder.Property(p => p.ZipCode).HasMaxLength(100);
            builder.Property(p => p.UserName).HasMaxLength(100);
            builder.Property(p => p.Password).HasMaxLength(50);
            builder.Property(p => p.PrimaryStoreIds).HasMaxLength(75);
            builder.Property(p => p.Token).HasMaxLength(500);

            builder.HasOne(p => p.Location).WithMany(p => p.Users)
            .HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }
}
