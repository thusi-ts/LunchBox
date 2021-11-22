using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.ViewModels
{
    public class StoreCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        public String StoreName { get; set; }

        public String Phone { get; set; }

        [Required]
        public String Email { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public String Logo { get; set; }

        public String Picture { get; set; }

        public String ZipCode { get; set; }

        public String Cvr { get; set; }

        public int ChainId { get; set; } = 1;

        public String ContactPersonName { get; set; }

        public String ContactPersonEmail { get; set; }

        public Decimal Discount { get; set; }

        public String Description { get; set; }

        public String Map { get; set; }

        public bool Active { get; set; } = true;

        public String ActiveOffMes { get; set; }

        public bool Pickup { get; set; } = true;

        public bool DeliveryOption { get; set; } = true;

        public String PickupTime { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public String OpenMan { get; set; } = "11-20";

        public String OpenTue { get; set; } = "11-20";

        public String OpenWed { get; set; } = "11-20";

        public String OpenThu { get; set; } = "11-20";

        public String OpenFre { get; set; } = "11-20";

        public String OpenSat { get; set; } = "11-20";

        public String OpenSun { get; set; } = "11-20";
        /*
        public ICollection<LocationsDelivery> LocationsDeliverys { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductExtraItem> ProductExtraItems { get; set; }
        public ICollection<ProductStoreLocation> ProductStoreLocations { get; set; }
        public ICollection<StoresPaymentDetail> StoresPaymentDetails { get; set; }
        public ICollection<CartTemp> TempCarts { get; set; }
        */
    }
}
