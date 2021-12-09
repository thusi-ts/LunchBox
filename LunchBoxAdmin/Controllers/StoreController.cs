using LunchBox.Shared;
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
        private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository )
        {
            this._storeRepository = storeRepository;
        }
        public ViewResult Index()
        {
            var model = _storeRepository.GetStores();
            return View(model);
        }

        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StoreCreateViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                Store newStore = new Store
                {
                    StoreName = model.StoreName,
                    
                };

                _storeRepository.AddStore(newStore);

                return RedirectToAction("Index", new { id = newStore.Id });



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
            
            storeRepository.AddStore(store);
            return View();
        }
    }
}
