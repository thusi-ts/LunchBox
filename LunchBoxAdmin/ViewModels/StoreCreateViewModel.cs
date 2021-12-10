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

        public String ZipCode { get; set; }

        public String Cvr { get; set; }

        public int ChainId { get; set; }

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

        public bool DeliveryOption { get; set; }

        public String PickupTime { get; set; }

        public String OpenMan { get; set; }

        public String OpenTue { get; set; }

        public String OpenWed { get; set; }

        public String OpenThu { get; set; }

        public String OpenFre { get; set; }

        public String OpenSat { get; set; }

        public String OpenSun { get; set; }
    }
}
