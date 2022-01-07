using LunchBox.Admin.ViewModels;
using LunchBox.Shared;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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

        public async Task<ProductListViewModelPagination> GetProductsList(int currentPage)
        {
            ProductListViewModelPagination ProductListViewModelPagination = new();

            int maxRows = ProductListViewModelPagination.maxRows;

            var leftOuterJoin = await (from product in appDBContext.Products
                                      join productExtraItem1 in appDBContext.ProductExtraItems on product.ProductExtraitem1Id equals productExtraItem1.Id into newProductExtraItem1Table
                                       from newProductExtraItem1Var in newProductExtraItem1Table.DefaultIfEmpty()
                                      select (new ProductListViewModel()
                                      {
                                          ProductName = product.ProductName,
                                          ProductExtraItemName = newProductExtraItem1Var.Name
                                      })).Skip((currentPage - 1) * maxRows).Take(10).ToListAsync();

            List<ProductListViewModel> productListViewModel = new();

            foreach (var result in leftOuterJoin)
            {
                productListViewModel.Add(
                    new ProductListViewModel {
                        ProductName = result.ProductName,
                        ProductExtraItemName = result.ProductExtraItemName,
                    }
                );
            }

            double pageCount = (double)((decimal)appDBContext.Products.Count() / Convert.ToDecimal(maxRows));
            
            ProductListViewModelPagination.PageCount = (int)Math.Ceiling(pageCount);
            ProductListViewModelPagination.CurrentPageIndex = currentPage;

            ProductListViewModelPagination.productListViewModel = productListViewModel;

            return ProductListViewModelPagination;

        }

        public async Task<IEnumerable<ProductListViewModel>> GetProductsListSQL(string filter) 
        {
            
            var SQLquery = await appDBContext.Products.FromSqlRaw(@"
                                SELECT  o.Id,
                                        o.Title,
                                        o.[Description],
                                        (
                                                SELECT  STRING_AGG(ot.Tag, ', ')
                                                FROM    OfferingTags ot
                                                        INNER JOIN OfferingsTags ots ON ot.Id = ots.TagsId
                                                WHERE   ots.OfferingsId = o.Id
                                        ) AS Tags
                                FROM Offerings o
                                WHERE   o.Title LIKE @filter
                                        OR o.[Description] LIKE @filter
                                        OR EXISTS(
                                            SELECT  1
                                            FROM OfferingTags ot
                                                    INNER JOIN OfferingsTags ots ON ot.Id = ots.TagsId
                                            WHERE ots.OfferingsId = o.Id
                                                AND ot.Tag LIKE @filter
                                                )",

            new SqlParameter("@filter", SqlDbType.NVarChar)
            {
                Value = $"%{filter}%",
            }).AsNoTracking().ToListAsync();

            List<ProductListViewModel> productListViewModel = new List<ProductListViewModel>();

            foreach (var result in SQLquery)
            {
                productListViewModel.Add(
                    new ProductListViewModel
                    {
                        ProductName = result.ProductName,
                        ProductExtraItemName = result.ProductName,
                    }
                );
            }

            return productListViewModel;
        }
    }
}

