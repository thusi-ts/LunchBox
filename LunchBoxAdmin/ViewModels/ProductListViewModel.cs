using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.ViewModels
{
    public class ProductListViewModel
    {
        public int Number { get; set; }

        public String Category { get; set; }
        
        public String ProductName { get; set; }

        public decimal Price { get; set; }

        public string ProductExtraItem1Name { get; set; }

        public String ProductExtraItem2Name { get; set; }

        public String ProductExtraItem3Name { get; set; }

        public String ProductExtraItem4Name { get; set; }

        public String Extraitem1 { get; set; }

        public String Extraitem2 { get; set; }

        public String Extraitem3 { get; set; }

        public String Extraitem4 { get; set; }
    }
}
