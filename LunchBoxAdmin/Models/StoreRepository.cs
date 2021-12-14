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

        public async Task<Boolean> DeleteStore(int id)
        {
            Store store = await GetStore(id);
            if(store != null)
            {
                appDBContext.Remove(store);
                await appDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Store> EditStore(Store editStore)
        {
            var result = appDBContext.Update(editStore);
            await appDBContext.SaveChangesAsync();
            
            return result.Entity;
        }

        public async Task<Store> GetStore(int id)
        {
            Store store = await appDBContext.Stores.FirstOrDefaultAsync(s => s.Id == id);
            if (store != null)
            {
                return store;
            }
            return null;
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            return await appDBContext.Stores.ToListAsync();
        }
    }
}
