using LunchBox.Shared;
using LunchBoxAdmin.Models;
using LunchBoxAdmin.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreRepository storeRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public StoreController(IStoreRepository storeRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.storeRepository = storeRepository;
            this.webHostEnvironment = webHostEnvironment;
        }
        public ViewResult Index()
        {
            var model = storeRepository.GetStores().Result;

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = storeRepository.GetStore(id).Result;
            return View(model);
        }

        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StoreCreateViewModel model)
        {
            // validate
            if (ModelState.IsValid)
            {
                // upload logo
                // upload picture
                String logo = null;

                if(model.Logo.FileName != null && model.Logo.Length > 0) {
                    String LogoPathFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/upload");
                    String uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Logo.FileName;
                    String filePath = Path.Combine(LogoPathFolder, uniqueFileName);

                    model.Logo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Store store = new Store
                {
                    Active = model.Active,
                    ActiveOffMes = model.ActiveOffMes,
                    ChainId = model.ChainId,
                    City = model.City,
                    Cvr = model.Cvr,
                    ContactPersonEmail = model.ContactPersonEmail,
                    ContactPersonName = model.ContactPersonName,
                    Created = DateTime.Now,
                    DeliveryOption = model.DeliveryOption,
                    Description = model.Description,
                    Discount = model.Discount,
                    Email = model.Email,
                    Pickup = model.Pickup,
                    PickupTime = model.PickupTime,
                    Logo = logo,
                    Map = model.Map,
                    OpenFre = model.OpenFre,
                    OpenMan = model.OpenMan,
                    OpenSat = model.OpenSat,
                    OpenSun = model.OpenSun,
                    OpenThu = model.OpenThu,
                    OpenTue = model.OpenTue,
                    OpenWed = model.OpenWed,
                    Phone = model.Phone,
                    StoreName = model.StoreName,
                    Street = model.Street,
                    ZipCode = model.ZipCode,
            };

                storeRepository.AddStore(store);
                //return RedirectToAction("Details", new { id = store.Id });
                return RedirectToAction("Index");
            }

            
            
            //
            return View();
        }
    }
}
