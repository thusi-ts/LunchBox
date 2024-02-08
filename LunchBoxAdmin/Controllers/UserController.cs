using LunchBox.Shared;
using LunchBoxAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<User> userManager;

        public UserController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = userManager.Users;

            return View(users);
        }
    }
}
