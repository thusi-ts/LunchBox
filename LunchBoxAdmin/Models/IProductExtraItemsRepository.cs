using LunchBox.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Models
{
    public interface IProductExtraItemsRepository
    {
        Task<IEnumerable<ProductExtraItem>> GetProductExtraItems();
    }
}
