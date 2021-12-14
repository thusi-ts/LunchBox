using LunchBox.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Models
{
    public interface IStoreRepository
    {
        Task<IEnumerable<Store>> GetStores();
        
        Task<Store> GetStore(int id);
        
        Task<Store> AddStore(Store store);
        
        Task<Store> EditStore(Store store);

        Task<Boolean> DeleteStore(int id);

    }
}
