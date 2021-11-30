using LunchBoxAdmin.Models;
using LunchBoxAdmin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreRepository storeRepository;

        public StoreController(IStoreRepository storeRepository )
        {
            this.storeRepository = storeRepository;
        }
        public IActionResult Index()
        {
            var model = storeRepository.GetStores();
            return View(model);
        }

        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Create(StoreCreateViewModel ModelState)
        {
            /*
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model); ModelState
            */
            storeRepository.AddStore(store);
            return View();
        }
    }
}
