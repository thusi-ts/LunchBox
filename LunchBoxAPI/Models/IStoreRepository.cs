﻿using Lunchbox.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.API
{
    public interface IStoreRepository
    {
        Task<IEnumerable<Store>> GetStores();
        
        Task<Store> GetStore(int id);
        
        Task<Store> AddStore(Store store);
        
        Task<Store> EditStore(Store store);

        Task DeleteStore(int id);

    }
}