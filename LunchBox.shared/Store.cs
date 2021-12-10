using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBox.Shared
{
    public class Store
    {
        public int Id { get; set; }

        public String StoreName { get; set; }

        public String Phone { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public String Email { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public String Logo { get; set; }

        public String ZipCode { get; set; }

        public String Cvr { get; set; }

        public int ChainId { get; set; }

        public String ContactPersonName { get; set; }

        public String ContactPersonEmail { get; set; }

        public Decimal Discount { get; set; }

        public String Description { get; set; }

        public String Map { get; set; }

        public bool Active { get; set; }

        public String ActiveOffMes { get; set; }

        public bool Pickup { get; set; }

        public bool DeliveryOption { get; set; }

        public String PickupTime { get; set; }

        public DateTime Created { get; set; }

        public String OpenMan { get; set; }

        public String OpenTue { get; set; }

        public String OpenWed { get; set; }

        public String OpenThu { get; set; }

        public String OpenFre { get; set; }

        public String OpenSat { get; set; }

        public String OpenSun { get; set; }

        public ICollection<LocationsDelivery> LocationsDeliverys { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductExtraItem> ProductExtraItems { get; set; }
        public ICollection<ProductStoreLocation> ProductStoreLocations { get; set; }
        public ICollection<StoresPaymentDetail> StoresPaymentDetails { get; set; }
        public ICollection<CartTemp> TempCarts { get; set; }
    }

    public class StoreImageEntityTypeConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.StoreName).HasMaxLength(250).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Street).HasMaxLength(100).IsRequired();
            builder.Property(p => p.City).HasMaxLength(100).IsRequired();
            builder.Property(p => p.ZipCode).HasMaxLength(100);
            builder.Property(p => p.Description).HasColumnType("nvarchar(max)");
            builder.Property(b => b.Discount).HasColumnType("decimal(5, 2)");
            builder.Property(p => p.ContactPersonName).HasMaxLength(100);
            builder.Property(p => p.Cvr).HasMaxLength(50);
            builder.Property(p => p.ContactPersonEmail).HasMaxLength(75);
            builder.Property(p => p.ActiveOffMes).HasMaxLength(500);
            builder.Property(p => p.PickupTime).HasMaxLength(50);
        }
    }
}
