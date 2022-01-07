using LunchBox.Admin.ViewModels;
using LunchBox.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly LbDbContext appDBContext;

        public ProductRepository(LbDbContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await appDBContext.Products.ToListAsync();
        }

        public async Task<IEnumerable<ProductListViewModel>> GetProductsList()
        {
            var authors = appDBContext.Products
                     .Include(p => p.ProductExtraItem1)
                     .Include(p => p.ProductExtraItem2)
                     .ToList();

            /*
             * 
             * now understand it concept
             * 
            var leftOuterJoin = await from p in appDBContext.Products 
                                      join pei in appDBContext.ProductExtraItems on p.ProductExtraItem1 equals pei.Id into pei1
                                from productExtraItem1 in pei1.DefaultIfEmpty()
                                select(new ProductListViewModel
                                {
                                    ProductName = p.ProductName,
                                    ProductExtraItemName = productExtraItem1.Name
                                }).ToListAsync();
            /*
            var query = await appDBContext.Products
                            .LeftJoin(appDBContext.ProductExtraItems,
                                product => product.Id,
                                productExtraItem => productExtraItem.Id,
                                (product, productExtraItem) => new
                                {
                                    productName = product.ProductName,
                                    productExtraItemName = productExtraItem.Name
                                }
                             ).ToListAsync();
            */

            List<ProductListViewModel> productListViewModel = new List<ProductListViewModel>();

            foreach (var result in leftOuterJoin)
            {
                productListViewModel.Add(
                    new ProductListViewModel {
                        ProductName = result.productName,
                        productExtraItemName = result.productExtraItemName,
                    }
                );
            }

            return productListViewModel;

        }

        public async Task<IEnumerable<ProductListViewModel>> GetProductsListSQL()
        {
            return appDBContext.Products

            List<ProductListViewModel> productListViewModel = new List<ProductListViewModel>();

            foreach (var result in leftOuterJoin)
            {
                productListViewModel.Add(
                    new ProductListViewModel
                    {
                        ProductName = result.productName,
                        productExtraItemName = result.productExtraItemName,
                    }
                );
            }

            return productListViewModel;

        }
    }
}

