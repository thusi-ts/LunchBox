using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LunchBox.Shared;

namespace LunchBoxAdmin.Controllers
{

    [Authorize]
    public class OrderController : Controller
    {
       [HttpGet]
        public IActionResult Index()
        {
            return View(new List<Order>());
        }
    }
}
