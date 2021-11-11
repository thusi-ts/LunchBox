using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public OrderMethodType OrderMethod { get; set; }

        [Required]
        public User User { get; set; }

        public int UserId { get; set; } = 0;

        [Column(TypeName = "nvarchar(100)")]
        public String UserOrderNumber { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public String UserOrderNumberName { get; set; }
        
        public OrderStatusType OrderStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime RequiredTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime ShippedTime { get; set; }

        public Store Strore { get; set; }

        public int StoreId { get; set; }

        [Column(TypeName = "ntext")]
        public String Comments { get; set; }

        public ICollection<OrderExtraItem> OrderExtraItems { get; set; }
        
    }

    //builder.Property(u => u.Provider).HasConversion<string>();

    public enum OrderMethodType
    {
        Levering = 1,
        Afhentning = 2
    }

    public enum OrderStatusType
    {
        Processing = 1,
        Completed = 2,
        Rejected = 3
    }
}