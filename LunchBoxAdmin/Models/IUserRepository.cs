using LunchBox.Shared;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}
