using LunchBox.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Models
{
    public class StoreRepository : IStoreRepository
    {

        private readonly LbDbContext appDBContext;

        public StoreRepository(LbDbContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }


        public async Task<Store> AddStore(Store store)
        {
            var result = await appDBContext.Stores.AddAsync(store);
            await appDBContext.SaveChangesAsync(); // ask not refresh, attach 
            return result.Entity;
        }

        public async Task DeleteStore(int id)
        {
            var result = await appDBContext.Stores.FirstOrDefaultAsync(s => s.Id == id);
            if(result != null)
            {
                appDBContext.Remove(result);
                await appDBContext.SaveChangesAsync();
            }
        }

        public async Task<Store> EditStore(Store editStore)
        {
            var result = appDBContext.Update(editStore);
            await appDBContext.SaveChangesAsync();
            
            return result.Entity;
        }

        public async Task<Store> GetStore(int id)
        {
            var result = await appDBContext.Stores.FirstOrDefaultAsync(s => s.Id == id);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            return await appDBContext.Stores.ToListAsync();
        }
    }
}
