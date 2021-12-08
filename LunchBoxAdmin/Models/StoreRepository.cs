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

        public async Task DeleteStore(int id)
        {
            var result = await appDBContext.Stores.FirstOrDefaultAsync(s => s.Id == id);
            if(result != null)
            {
                appDBContext.Stores.Remove(result);
                await appDBContext.SaveChangesAsync();
            }
        }

        public async Task<Store> EditStore(Store store)
        {
            var result = await appDBContext.Stores.FirstOrDefaultAsync(s => s.Id == store.Id);
            if (result != null)
            {
                result.Active = store.Active;
                result.ActiveOffMes = store.ActiveOffMes;
                result.ChainId = store.ChainId;
                result.City = store.City;
                result.ContactPersonEmail = store.ContactPersonEmail;
                result.ContactPersonName = store.ContactPersonName;
                result.Created = store.Created;
                result.DeliveryOption = store.DeliveryOption;
                result.Description = store.Description;
                result.Discount = store.Discount;
                result.Email = store.Email;
                result.Logo = store.Logo;
                result.Map = store.Map;
                result.OpenFre = store.OpenFre;
                result.OpenMan = store.OpenMan;
                result.OpenSat = store.OpenSat;
                result.OpenSun = store.OpenSun;
                result.OpenThu = store.OpenThu;
                result.OpenTue = store.OpenTue;
                result.OpenWed = store.OpenWed;
                result.Phone = store.Phone;
                result.StoreName = store.StoreName;
                result.Street = store.Street;
                result.ZipCode = store.ZipCode;
                await appDBContext.SaveChangesAsync();
                
                return result;
            }
            return null;
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
