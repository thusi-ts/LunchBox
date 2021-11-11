using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class TempCart
    {
        public int TempCartId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String SessionId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ModifiedTime { get; set; } = DateTime.Now;

        public Store Store { get; set; }

        public int StoreId { get; set; }
        
        public Product Product { get; set; }

        public int ProductId { get; set; }
        
        public int Quantity { get; set; }

        [Column(TypeName = "ntext")]
        public int Comments { get; set; }

        public ICollection<TempCartExtraItem> TempCartExtraItems { get; set; }
        
    }
}
