using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class LocationsDelivery
    {
        
        public Location Location { get; set; }

        [Key]
        public int LocationId { get; set; }

        public Store Store { get; set; }

        [Key]
        public int StoreId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public String DeliveryTime { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public String OrderClosingTime { get; set; }

        public int Active { get; set; }
    }
}
