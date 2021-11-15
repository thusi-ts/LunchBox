using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Location name")]
        [Column(TypeName = "nvarchar(200)")]
        public String LocationName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public String Phone { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public String Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public String Street { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public String City { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public String Logo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public String Picture { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public String ZipCode { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public String Cvr { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public String ContactPersonName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public String ContactPersonEmail { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public String Map { get; set; }

        [Column(TypeName = "ntext")]
        public String Description { get; set; }
        public int Active { get; set; }

        [Column(TypeName = "ntext")]
        public String ActiveOffMes { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public ICollection<LocationsDelivery> LocationsDeliverys { get; set; }
        public ICollection<ProductStoreLocation> ProductStoreLocations { get; set; }
        public ICollection<User> Users { get; set; }

    }
}

//next default værdi