using LunchBox.Admin.ViewModels;
using LunchBox.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Models
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<IEnumerable<ProductListViewModel>> GetProductsList();

        Task<IEnumerable<ProductListViewModel>> GetProductsListSQL();
    }
}
