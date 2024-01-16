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
            await appDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Store> DeleteStore(int id)
        {
            var result = await appDBContext.Stores.FirstOrDefaultAsync(s => s.Id == id);
            if (result != null)
            {
                try
                {
                    appDBContext.Stores.Remove(result);
                    await appDBContext.SaveChangesAsync();
                    
                    return result;
                }
                catch (ObjectDisposedException e)
                {
                    Console.WriteLine("Store: {0}", result.Id);
                    Console.WriteLine("Caught: {0}", e.Message);
                }
                
            }
            return null;
        }

        public async Task<Store> EditStore(Store editStore)
        {
            var result = appDBContext.Update(editStore);
            await appDBContext.SaveChangesAsync();
            
            return result.Entity;
        }

        public async Task<Store> GetStore(int id)
        {
            return await appDBContext.Stores.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            return await appDBContext.Stores.ToListAsync();
        }
    }
}
