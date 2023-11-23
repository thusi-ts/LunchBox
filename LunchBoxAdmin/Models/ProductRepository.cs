using LunchBox.Admin.ViewModels;
using LunchBox.Shared;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
                                        join category in appDBContext.ProductCategorys on product.ProductCategoryId equals category.Id 
                                        join Item1 in appDBContext.ProductExtraItems on product.ProductExtraitem1Id equals Item1.Id into newItem1Table from newItem1Var in newItem1Table.DefaultIfEmpty()
                                        join Item2 in appDBContext.ProductExtraItems on product.ProductExtraitem2Id equals Item2.Id into newItem2Table from newItem2Var in newItem2Table.DefaultIfEmpty()
                                        join Item3 in appDBContext.ProductExtraItems on product.ProductExtraitem3Id equals Item3.Id into newItem3Table from newItem3Var in newItem3Table.DefaultIfEmpty()
                                        join Item4 in appDBContext.ProductExtraItems on product.ProductExtraitem4Id equals Item4.Id into newItem4Table from newItem4Var in newItem4Table.DefaultIfEmpty()
                                        select (new ProductListViewModel()
                                        {
                                            Category = category.CategoryName,
                                            Price = product.Price,
                                            ProductName = product.ProductName,
                                            
                                            ProductExtraItem1Name = newItem1Var.Name,
                                            Extraitem1 = (newItem1Var.ItemName1 == null ? "" : newItem1Var.ItemName1+((newItem1Var.ItemPrice1 > 0 ? " "+newItem1Var.ItemPrice1 : "")))
                                                        + (newItem1Var.ItemName2 == null ? "" : ", " + newItem1Var.ItemName2 + ((newItem1Var.ItemPrice2 > 0 ? " " + newItem1Var.ItemPrice2 : "")))
                                                        + (newItem1Var.ItemName3 == null ? "" : ", " + newItem1Var.ItemName3 + ((newItem1Var.ItemPrice3 > 0 ? " " + newItem1Var.ItemPrice3 : "")))
                                                        + (newItem1Var.ItemName4 == null ? "" : ", " + newItem1Var.ItemName4 + ((newItem1Var.ItemPrice4 > 0 ? " " + newItem1Var.ItemPrice4 : "")))
                                                        + (newItem1Var.ItemName5 == null ? "" : ", " + newItem1Var.ItemName5 + ((newItem1Var.ItemPrice5 > 0 ? " " + newItem1Var.ItemPrice5 : "")))
                                                        + (newItem1Var.ItemName6 == null ? "" : ", " + newItem1Var.ItemName6 + ((newItem1Var.ItemPrice6 > 0 ? " " + newItem1Var.ItemPrice6 : "")))
                                                        + (newItem1Var.ItemName7 == null ? "" : ", " + newItem1Var.ItemName7 + ((newItem1Var.ItemPrice7 > 0 ? " " + newItem1Var.ItemPrice7 : "")))
                                                        + (newItem1Var.ItemName8 == null ? "" : ", " + newItem1Var.ItemName8 + ((newItem1Var.ItemPrice8 > 0 ? " " + newItem1Var.ItemPrice8 : "")))
                                                        + (newItem1Var.ItemName9 == null ? "" : ", " + newItem1Var.ItemName9 + ((newItem1Var.ItemPrice9 > 0 ? " " + newItem1Var.ItemPrice9 : "")))
                                                        + (newItem1Var.ItemName10 == null ? "" : ", " + newItem1Var.ItemName10 + ((newItem1Var.ItemPrice10 > 0 ? " " + newItem1Var.ItemPrice10 : ""))),

                                            ProductExtraItem2Name = newItem2Var.Name,
                                            Extraitem2 = (newItem2Var.ItemName1 == null ? "" : newItem2Var.ItemName1 + ((newItem2Var.ItemPrice1 > 0 ? " " + newItem2Var.ItemPrice1 : "")))
                                                        + (newItem2Var.ItemName2 == null ? "" : ", " + newItem2Var.ItemName2 + ((newItem2Var.ItemPrice2 > 0 ? " " + newItem2Var.ItemPrice2 : "")))
                                                        + (newItem2Var.ItemName3 == null ? "" : ", " + newItem2Var.ItemName3 + ((newItem2Var.ItemPrice3 > 0 ? " " + newItem2Var.ItemPrice3 : "")))
                                                        + (newItem2Var.ItemName4 == null ? "" : ", " + newItem2Var.ItemName4 + ((newItem2Var.ItemPrice4 > 0 ? " " + newItem2Var.ItemPrice4 : "")))
                                                        + (newItem2Var.ItemName5 == null ? "" : ", " + newItem2Var.ItemName5 + ((newItem2Var.ItemPrice5 > 0 ? " " + newItem2Var.ItemPrice5 : "")))
                                                        + (newItem2Var.ItemName6 == null ? "" : ", " + newItem2Var.ItemName6 + ((newItem2Var.ItemPrice6 > 0 ? " " + newItem2Var.ItemPrice6 : "")))
                                                        + (newItem2Var.ItemName7 == null ? "" : ", " + newItem2Var.ItemName7 + ((newItem2Var.ItemPrice7 > 0 ? " " + newItem2Var.ItemPrice7 : "")))
                                                        + (newItem2Var.ItemName8 == null ? "" : ", " + newItem2Var.ItemName8 + ((newItem2Var.ItemPrice8 > 0 ? " " + newItem2Var.ItemPrice8 : "")))
                                                        + (newItem2Var.ItemName9 == null ? "" : ", " + newItem2Var.ItemName9 + ((newItem2Var.ItemPrice9 > 0 ? ", " + newItem2Var.ItemPrice9 : "")))
                                                        + (newItem2Var.ItemName10 == null ? "" : ", " + newItem2Var.ItemName10 + ((newItem2Var.ItemPrice10 > 0 ? " " + newItem2Var.ItemPrice10 : ""))),

                                            ProductExtraItem3Name = newItem3Var.Name,
                                            Extraitem3 = (newItem3Var.ItemName1 == null ? "" : newItem3Var.ItemName1 + ((newItem3Var.ItemPrice1 > 0 ? " " + newItem3Var.ItemPrice1 : "")))
                                                        + (newItem3Var.ItemName2 == null ? "" : ", " + newItem3Var.ItemName2 + ((newItem3Var.ItemPrice2 > 0 ? " " + newItem3Var.ItemPrice2 : "")))
                                                        + (newItem3Var.ItemName3 == null ? "" : ", " + newItem3Var.ItemName3 + ((newItem3Var.ItemPrice3 > 0 ? " " + newItem3Var.ItemPrice3 : "")))
                                                        + (newItem3Var.ItemName4 == null ? "" : ", " + newItem3Var.ItemName4 + ((newItem3Var.ItemPrice4 > 0 ? " " + newItem3Var.ItemPrice4 : "")))
                                                        + (newItem3Var.ItemName5 == null ? "" : ", " + newItem3Var.ItemName5 + ((newItem3Var.ItemPrice5 > 0 ? " " + newItem3Var.ItemPrice5 : "")))
                                                        + (newItem3Var.ItemName6 == null ? "" : ", " + newItem3Var.ItemName6 + ((newItem3Var.ItemPrice6 > 0 ? " " + newItem3Var.ItemPrice6 : "")))
                                                        + (newItem3Var.ItemName7 == null ? "" : ", " + newItem3Var.ItemName7 + ((newItem3Var.ItemPrice7 > 0 ? " " + newItem3Var.ItemPrice7 : "")))
                                                        + (newItem3Var.ItemName8 == null ? "" : ", " + newItem3Var.ItemName8 + ((newItem3Var.ItemPrice8 > 0 ? " " + newItem3Var.ItemPrice8 : "")))
                                                        + (newItem3Var.ItemName9 == null ? "" : ", " + newItem3Var.ItemName9 + ((newItem3Var.ItemPrice9 > 0 ? " " + newItem3Var.ItemPrice9 : "")))
                                                        + (newItem3Var.ItemName10 == null ? "" : ", " + newItem3Var.ItemName10 + ((newItem3Var.ItemPrice10 > 0 ? " " + newItem3Var.ItemPrice10 : ""))),

                                            ProductExtraItem4Name = newItem4Var.Name,
                                            Extraitem4 = (newItem4Var.ItemName1 == null ? "" : newItem4Var.ItemName1 + ((newItem4Var.ItemPrice1 > 0 ? " " + newItem4Var.ItemPrice1 : "")))
                                                        + (newItem4Var.ItemName2 == null ? "" : ", " + newItem4Var.ItemName2 + ((newItem4Var.ItemPrice2 > 0 ? " " + newItem4Var.ItemPrice2 : "")))
                                                        + (newItem4Var.ItemName3 == null ? "" : ", " + newItem4Var.ItemName3 + ((newItem4Var.ItemPrice3 > 0 ? " " + newItem4Var.ItemPrice3 : "")))
                                                        + (newItem4Var.ItemName4 == null ? "" : ", " + newItem4Var.ItemName4 + ((newItem4Var.ItemPrice4 > 0 ? " " + newItem4Var.ItemPrice4 : "")))
                                                        + (newItem4Var.ItemName5 == null ? "" : ", " + newItem4Var.ItemName5 + ((newItem4Var.ItemPrice5 > 0 ? " " + newItem4Var.ItemPrice5 : "")))
                                                        + (newItem4Var.ItemName6 == null ? "" : ", " + newItem4Var.ItemName6 + ((newItem4Var.ItemPrice6 > 0 ? " " + newItem4Var.ItemPrice6 : "")))
                                                        + (newItem4Var.ItemName7 == null ? "" : ", " + newItem4Var.ItemName7 + ((newItem4Var.ItemPrice7 > 0 ? " " + newItem4Var.ItemPrice7 : "")))
                                                        + (newItem4Var.ItemName8 == null ? "" : ", " + newItem4Var.ItemName8 + ((newItem4Var.ItemPrice8 > 0 ? "" + newItem4Var.ItemPrice8 : "")))
                                                        + (newItem4Var.ItemName9 == null ? "" : ", " + newItem4Var.ItemName9 + ((newItem4Var.ItemPrice9 > 0 ? " " + newItem4Var.ItemPrice9 : "")))
                                                        + (newItem4Var.ItemName10 == null ? "" : ", " + newItem4Var.ItemName10 + ((newItem4Var.ItemPrice10 > 0 ? ", " + newItem4Var.ItemPrice10 : ""))),

                                        })).Skip((currentPage - 1) * maxRows).Take(10).ToListAsync();

            List<ProductListViewModel> productListViewModel = new();
            int i = 1;
            foreach (var result in leftOuterJoin)
            {
                productListViewModel.Add(
                    new ProductListViewModel {
                        Number = i,
                        ProductName = result.ProductName,
                        Category = result.Category,
                        Price = result.Price,
                        ProductExtraItem1Name = result.ProductExtraItem1Name,
                        ProductExtraItem2Name = result.ProductExtraItem2Name,
                        ProductExtraItem3Name = result.ProductExtraItem3Name,
                        ProductExtraItem4Name = result.ProductExtraItem4Name,
                        Extraitem1 = result.Extraitem1,
                        Extraitem2 = result.Extraitem2,
                        Extraitem3 = result.Extraitem3,
                        Extraitem4 = result.Extraitem4,
                    }
                );
                i++;
            }

            double pageCount = (double)((decimal)appDBContext.Products.Count() / Convert.ToDecimal(maxRows));
            
            ProductListViewModelPagination.PageCount = (int)Math.Ceiling(pageCount);
            ProductListViewModelPagination.CurrentPageIndex = currentPage;

            ProductListViewModelPagination.ProductListViewModel = productListViewModel;

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
                        ProductExtraItem1Name = result.ProductName,
                    }
                );
            }

            return productListViewModel;
        }
    }
}

