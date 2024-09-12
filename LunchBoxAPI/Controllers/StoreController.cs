using LunchBox.Shared;
using LunchBoxAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }
        [HttpGet("stores")]
        public async Task<IActionResult> Index()
        {
            var model = await storeRepository.GetStores();

            return Ok(model);
        }
    }
}