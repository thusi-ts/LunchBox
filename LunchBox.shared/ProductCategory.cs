using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public String CategoryName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public String ImageFolder { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
