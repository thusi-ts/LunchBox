using LunchBox.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Models
{
    public class UserRepository : IUserRepository
    {

        private readonly UserManager<User> userManager;

        public UserRepository(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public IEnumerable<User> GetUsers()
        {
            var users = userManager.Users;
            return users;
        }
    }
}
