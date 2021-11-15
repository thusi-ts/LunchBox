using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class ProductExtraItem
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        public String ItemMachineName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public String ItemName { get; set; }
        
        public Store Store { get; set; }

        public int StoreId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName1 { get; set; }
        
        public decimal ItemPrice1 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName2 { get; set; }
        
        public decimal ItemPrice2 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName3 { get; set; }
        
        public decimal ItemPrice3 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName4 { get; set; }
        
        public decimal ItemPrice4 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName5 { get; set; }
        
        public decimal ItemPrice5 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName6 { get; set; }
        
        public decimal ItemPrice6 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName7 { get; set; }
        
        public decimal ItemPrice7 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName8 { get; set; }
        
        public decimal ItemPrice8 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName9 { get; set; }
        
        public decimal ItemPrice9 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName10 { get; set; }
        
        public decimal ItemPrice10 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName11 { get; set; }
        
        public decimal ItemPrice11 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName12 { get; set; }
        
        public decimal ItemPrice12 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName13 { get; set; }
        
        public decimal ItemPrice13 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName14 { get; set; }
        
        public decimal ItemPrice14 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName15 { get; set; }
        
        public decimal ItemPrice15 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName16 { get; set; }
        
        public decimal ItemPrice16 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName17 { get; set; }
        
        public decimal ItemPrice17 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName18 { get; set; }
        
        public decimal ItemPrice18 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName19 { get; set; }
        
        public decimal ItemPrice19 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ItemName20 { get; set; }
        
        public decimal ItemPrice20 { get; set; }

        public ICollection<OrderExtraItem> OrderExtraItems { get; set; }
        public ICollection<CartTempExtraItem> TempCartExtraItems { get; set; }
        public ICollection<Product> Products1 { get; set; }
        public ICollection<Product> Products2 { get; set; }
        public ICollection<Product> Products3 { get; set; }
        public ICollection<Product> Products4 { get; set; }
        public ICollection<Product> Products5 { get; set; }
        public ICollection<Product> Products6 { get; set; }
        public ICollection<Product> Products7 { get; set; }
        public ICollection<Product> Products8 { get; set; }
        public ICollection<Product> Products9 { get; set; }
        public ICollection<Product> Products10 { get; set; }
    }
}
