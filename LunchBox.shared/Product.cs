using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public String ProductName { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public int ProductCategoryId { get; set; }
        
        public Store Store { get; set; }

        public int StoreId { get; set; }

        public decimal Price { get; set; }
        
        public decimal Discount { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public String Picture { get; set; }

        public int Active { get; set; } = 1;

        [Column(TypeName = "ntext")]
        public String ActiveOffMes { get; set; }
        
        public ProductExtraItem ProductExtraItem1 { get; set; }

        public int? ProductExtraitem1Id { get; set; }

        public int ProductExtraitemMandatory1 { get; set; }
        
        public ProductExtraItem ProductExtraItem2 { get; set; }
        
        public int? ProductExtraitem2Id { get; set; }
        
        public int ProductExtraitemMandatory2 { get; set; }

        public ProductExtraItem ProductExtraItem3 { get; set; }

        public int? ProductExtraitem3Id { get; set; }
        
        public int ProductExtraitemMandatory3 { get; set; }

        public ProductExtraItem ProductExtraItem4 { get; set; }

        public int? ProductExtraitem4Id { get; set; }
        
        public int ProductExtraitemMandatory4 { get; set; }

        public ProductExtraItem ProductExtraItem5 { get; set; }

        public int? ProductExtraitem5Id { get; set; }
        
        public int ProductExtraitemMandatory5 { get; set; }

        public ProductExtraItem ProductExtraItem6 { get; set; }

        public int? ProductExtraitem6Id { get; set; }
        
        public int ProductExtraitemMandatory6 { get; set; }

        public ProductExtraItem ProductExtraItem7 { get; set; }

        public int? ProductExtraitem7Id { get; set; }
        
        public int ProductExtraitemMandatory7 { get; set; }

        public ProductExtraItem ProductExtraItem8 { get; set; }

        public int? ProductExtraitem8Id { get; set; }
        
        public int ProductExtraitemMandatory8 { get; set; }

        public ProductExtraItem ProductExtraItem9 { get; set; }

        public int? ProductExtraitem9Id { get; set; }
        
        public int ProductExtraitemMandatory9 { get; set; }

        public ProductExtraItem ProductExtraItem10 { get; set; }

        public int? ProductExtraitem10Id { get; set; }
        
        public int ProductExtraitemMandatory10 { get; set; }

        public ICollection<OrderExtraItem> OrderExtraItems { get; set; }
        public ICollection<ProductStoreLocation> ProductStoreLocations { get; set; }
        public ICollection<TempCart> TempCarts { get; set; }
    }
}
