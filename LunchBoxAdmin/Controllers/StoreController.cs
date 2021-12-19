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
        public async Task<ViewResult> Index()
        {
            var model = await storeRepository.GetStores(); // ask and not refresh

            return View(model);
        }

        public async Task<ViewResult> Details(int id)
        {
            var model = await storeRepository.GetStore(id);
            if (model == null)
            {
                ViewBag.ErrorMessage = $"Store with Id = {id} cannot be found";
                return View("NotFound");
            }
            return View(model);
        }

        public ViewResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(StoreCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                String logoUniqueFileName = LogoUploadProcess(model);

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
                    Logo = logoUniqueFileName,
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

                await storeRepository.AddStore(store);
                return RedirectToAction("Index");
            }
            return View();
        }

        private string LogoUploadProcess(StoreCreateViewModel model)
        {
            String logoUniqueFileName = null;
            if (model.Logo != null)
            {
                if (model.Logo.FileName != null && model.Logo.Length > 0)
                {
                    String LogoPathFolder = Path.Combine(webHostEnvironment.WebRootPath, "images\\upload");
                    logoUniqueFileName = Guid.NewGuid().ToString() + "_" + model.Logo.FileName;
                    String filePath = Path.Combine(LogoPathFolder, logoUniqueFileName);

                    using var fileStream = new FileStream(filePath, FileMode.Create);
                    model.Logo.CopyTo(fileStream);
                }
            }

            return logoUniqueFileName;
        }

        public async Task<ViewResult> Edit(int id)
        {
            var result = await storeRepository.GetStore(id);
            
            StoreEditViewModel storeEditModel = new StoreEditViewModel
            {
                Id = result.Id,
                Active = result.Active,
                ActiveOffMes = result.ActiveOffMes,
                ChainId = result.ChainId,
                City = result.City,
                Cvr = result.Cvr,
                ContactPersonEmail = result.ContactPersonEmail,
                ContactPersonName = result.ContactPersonName,
                DeliveryOption = result.DeliveryOption,
                Description = result.Description,
                Discount = result.Discount,
                Email = result.Email,
                Pickup = result.Pickup,
                PickupTime = result.PickupTime,
                ExistingLogoPath = result.Logo,
                Map = result.Map,
                OpenFre = result.OpenFre,
                OpenMan = result.OpenMan,
                OpenSat = result.OpenSat,
                OpenSun = result.OpenSun,
                OpenThu = result.OpenThu,
                OpenTue = result.OpenTue,
                OpenWed = result.OpenWed,
                Phone = result.Phone,
                StoreName = result.StoreName,
                Street = result.Street,
                ZipCode = result.ZipCode,
            };
            return View(storeEditModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(StoreEditViewModel model)
        {
            String logoPath = null;

            if (ModelState.IsValid)
            {
                if (model.Logo != null)
                {
                    if (model.ExistingLogoPath != null)
                    {
                        String ExistingLogoPath = Path.Combine(webHostEnvironment.WebRootPath, "images\\upload", model.ExistingLogoPath);
                        if (System.IO.File.Exists(ExistingLogoPath))
                        {
                            System.IO.File.Delete(ExistingLogoPath);
                        }
                        
                    }
                    logoPath = LogoUploadProcess(model);
                }

                Store store = new Store
                {
                    Id = model.Id,
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
                    Logo = logoPath,
                    PickupTime = model.PickupTime,
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

                await storeRepository.EditStore(store);
                return RedirectToAction("Details", new { id = model.Id });
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await storeRepository.GetStore(id);
            if (result == null)
            {
                ViewBag.ErrorMessage = $"Store with Id = {id} cannot be found";
                return View("NotFound"); 
            }
            else
            {
                await storeRepository.DeleteStore(id);
                return RedirectToAction("Index");
            }
        }
    }
}