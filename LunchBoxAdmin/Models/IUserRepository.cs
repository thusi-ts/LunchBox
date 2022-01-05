using LunchBox.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Models
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUser(int id);

        Task<User> AddUser(Store store);

        Task<User> EditUser(Store store);

        Task<User> DeleteUser(int id);
    }
}
