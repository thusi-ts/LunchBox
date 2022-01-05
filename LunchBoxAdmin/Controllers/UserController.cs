using LunchBox.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userReposotory;

        public UserController(IUserRepository userReposotory)
        {
            this.userReposotory = userReposotory;
        }

        public async Task<ViewResult> Index()
        {
            var model = await userReposotory.GetUsers();
            
            return View(model);
        }
    }
}
