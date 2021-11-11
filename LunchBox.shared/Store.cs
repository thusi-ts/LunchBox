using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Store name")]
        [Column(TypeName = "nvarchar(100)")]
        public String StoreName { get; set; }

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

        [Column(TypeName = "nvarchar(200)")]
        public String Logo { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public String Picture { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public String ZipCode { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public String Cvr { get; set; }

        [DefaultValue("0")]
        [Description("Evt. kæde")]
        public int ChainId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String ContactPersonName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String ContactPersonEmail { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Discount { get; set; }

        [Column(TypeName = "ntext")]
        public String Description { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public String Map { get; set; }

        public bool Active { get; set; } = true;

        [Column(TypeName = "nvarchar(400)")]
        public String ActiveOffMes { get; set; }

        public bool Pickup { get; set; } = true;

        [DefaultValue("true")]
        [Description("Mulighed for udbringning")]
        public bool DeliveryOption { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public String PickupTime { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Created { get; set; } = DateTime.Now;

        [Column(TypeName = "nvarchar(10)")]
        [Description("11-20")]
        public String OpenMan { get; set; } = "11-20";

        [Column(TypeName = "nvarchar(10)")]
        [Description("11-20")]
        public String OpenTue { get; set; } = "11-20";

        [Column(TypeName = "nvarchar(10)")]
        [Description("11-20")]
        public String OpenWed { get; set; } = "11-20";

        [Column(TypeName = "nvarchar(10)")]
        [Description("11-20")]
        public String OpenThu { get; set; } = "11-20";

        [Column(TypeName = "nvarchar(10)")]
        [Description("11-20")]
        public String OpenFre { get; set; } = "11-20";

        [Column(TypeName = "nvarchar(10)")]
        [Description("11-20")]
        public String OpenSat { get; set; } = "11-20";

        [Column(TypeName = "nvarchar(10)")]
        [Description("11-20")]
        public String OpenSun { get; set; } = "11-20";

        public ICollection<LocationsDelivery> LocationsDeliverys { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductExtraItem> ProductExtraItems { get; set; }
        public ICollection<ProductStoreLocation> ProductStoreLocations { get; set; }
        public ICollection<StoresPaymentDetail> StoresPaymentDetails { get; set; }
        public ICollection<TempCart> TempCarts { get; set; }

        




    }
}
