using LunchBoxAdmin.ViewModels;
using LunchBox.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Models
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<ProductListViewModelPagination> GetProductsList(int currentPageIndex);

        Task<IEnumerable<ProductListViewModel>> GetProductsListSQL(string filter);
    }
}
