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

        public async Task<Store> DeleteStore(int id)
        {
            var test = await appDBContext.Stores.ToListAsync();
            Store store = await GetStore(id);
            if(store != null)
            {
                try
                {
                    appDBContext.Stores.Remove(store);
                    await appDBContext.SaveChangesAsync();
                }
                catch (ObjectDisposedException e)
                {
                    
                    Console.WriteLine("Caught: {0}", e.Message);
                }
                
            }
            return store;
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
