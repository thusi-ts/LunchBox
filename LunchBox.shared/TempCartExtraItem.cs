using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class TempCartExtraItem
    {
        [Key]
        public int TempCartId { get; set; }
        
        public ProductExtraItem ProductExtraItem { get; set; }

        public int ProductExtraItemId { get; set; }
        
        [Column(TypeName = "nvarchar(250)")]
        public String ProductExtraItemName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String ProductExtraItemValue { get; set; }
    }
}
