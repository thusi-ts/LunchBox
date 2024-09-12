using LunchBox.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LunchBoxAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("users")]
        public IActionResult Index()
        {
            var users = new List<User>() 
                { 
                    new User { UserName = "Thusi", City = "Struer" }, 
                    new User { UserName = "Thomas", City = "Herning" } 
                };

            return Ok(users);
        }
    }
}
