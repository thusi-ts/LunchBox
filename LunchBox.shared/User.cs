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

        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        [Column(TypeName = "nvarchar(100)")]
        public String Fullname { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String Phone { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String Street { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String City { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String ZipCode { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public String UserName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public String Password { get; set; }

        public int Active { get; set; } = 1;

        [Column(TypeName = "nvarchar(50)")]
        public String Role { get; set; }

        public int Newsletter { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime EnteredTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastModifiedTime { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public String PrimaryStoreIds { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Token { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

    public class UserImageEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(d => d.Id);
        }
    }
}
