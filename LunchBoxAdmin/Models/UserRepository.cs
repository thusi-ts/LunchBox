using LunchBox.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Models
{
    public class UserRepository : IUserRepository
    {

        private readonly LbDbContext appDBContext;

        public UserRepository(LbDbContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public Task<User> AddUser(Store store)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> EditUser(Store store)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await appDBContext.Users.ToListAsync();
        }
    }
}
