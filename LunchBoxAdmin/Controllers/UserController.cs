using LunchBoxAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserRepository userReposotory;

        public UserController(IUserRepository userReposotory)
        {
            this.userReposotory = userReposotory;
        }

        public IActionResult Index()
        {
            var model = userReposotory.GetUsers();
            
            return View(model);
        }
    }
}
