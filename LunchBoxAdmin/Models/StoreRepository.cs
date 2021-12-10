﻿using LunchBox.Shared;
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
            await appDBContext.SaveChangesAsync(); // ask not refresh
            return result.Entity;
        }

        public async Task DeleteStore(int id)
        {
            var result = await appDBContext.Stores.FirstOrDefaultAsync(s => s.Id == id);
            if(result != null)
            {
                appDBContext.Stores.Remove(result);
                await appDBContext.SaveChangesAsync();
            }
        }

        public async Task<Store> EditStore(Store editStore)
        {
            var store = appDBContext.Stores.Attach(editStore);
            store.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await appDBContext.SaveChangesAsync();
            
            return editStore;
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
