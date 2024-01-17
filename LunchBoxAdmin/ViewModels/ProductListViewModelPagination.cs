using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.ViewModels
{
    public class ProductListViewModelPagination
    {
        public List<ProductListViewModel> ProductListViewModel { get; set; }

        public int CurrentPageIndex { get; set; }

        public int PageCount { get; set; }

        public int MaxRows { get; set; } = 10;
}
}
