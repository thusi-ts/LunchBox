using LunchBox.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Models
{
    public class ProductExtraItemsRepository : IProductExtraItemsRepository
    {
        private readonly LbDbContext appDBContext;

        public ProductExtraItemsRepository(LbDbContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public async Task<IEnumerable<ProductExtraItem>> GetProductExtraItems()
        {
            return await appDBContext.ProductExtraItems.ToListAsync();
        }
    }
}
