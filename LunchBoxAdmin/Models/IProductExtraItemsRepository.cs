using LunchBox.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Models
{
    public interface IProductExtraItemsRepository
    {
        Task<IEnumerable<ProductExtraItem>> GetProductExtraItems();
    }
}
