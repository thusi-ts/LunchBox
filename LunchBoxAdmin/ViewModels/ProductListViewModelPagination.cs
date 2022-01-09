using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.ViewModels
{
    public class ProductListViewModelPagination
    {
        public List<ProductListViewModel> ProductListViewModel { get; set; }

        public int CurrentPageIndex { get; set; }

        public int PageCount { get; set; }

        public int maxRows { get; set; } = 10;
}
}
