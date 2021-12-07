using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.ViewModels
{
    public class StoreCreateViewModel
    {
        [Required]
        [Display(Name = "Store")]
        public String StoreName { get; set; }

        [Required]
        public String Phone { get; set; }

        [Required]
        public String Email { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public IFormFile Logo { get; set; }

        public IFormFile Picture { get; set; }

        public String ZipCode { get; set; }

        public String Cvr { get; set; }

        public int ChainId { get; set; } = 1;

        public String ContactPersonName { get; set; }

        public String ContactPersonEmail { get; set; }

        [Range(0, 99.99)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Discount { get; set; }

        public String Description { get; set; }

        public String Map { get; set; }

        public bool Active { get; set; } = true;

        public String ActiveOffMes { get; set; }

        public bool Pickup { get; set; } = true;

        public bool DeliveryOption { get; set; } = true;

        public String PickupTime { get; set; }

        public String OpenMan { get; set; } = "11-20";

        public String OpenTue { get; set; } = "11-20";

        public String OpenWed { get; set; } = "11-20";

        public String OpenThu { get; set; } = "11-20";

        public String OpenFre { get; set; } = "11-20";

        public String OpenSat { get; set; } = "11-20";

        public String OpenSun { get; set; } = "11-20";
    }
}
