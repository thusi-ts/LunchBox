﻿using LunchBox.Shared;
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
            var model = storeRepository.GetStores().Result; // ask and not refresh

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = storeRepository.GetStore(id).Result;
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
        public IActionResult Create(StoreCreateViewModel model)
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

                storeRepository.AddStore(store);
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

        public ViewResult Edit(int id)
        {
            Store store = storeRepository.GetStore(id).Result;
            StoreEditViewModel storeEditModel = new StoreEditViewModel
            {
                Id = store.Id,
                Active = store.Active,
                ActiveOffMes = store.ActiveOffMes,
                ChainId = store.ChainId,
                City = store.City,
                Cvr = store.Cvr,
                ContactPersonEmail = store.ContactPersonEmail,
                ContactPersonName = store.ContactPersonName,
                DeliveryOption = store.DeliveryOption,
                Description = store.Description,
                Discount = store.Discount,
                Email = store.Email,
                Pickup = store.Pickup,
                PickupTime = store.PickupTime,
                ExistingLogoPath = store.Logo,
                Map = store.Map,
                OpenFre = store.OpenFre,
                OpenMan = store.OpenMan,
                OpenSat = store.OpenSat,
                OpenSun = store.OpenSun,
                OpenThu = store.OpenThu,
                OpenTue = store.OpenTue,
                OpenWed = store.OpenWed,
                Phone = store.Phone,
                StoreName = store.StoreName,
                Street = store.Street,
                ZipCode = store.ZipCode,
            };
            return View(storeEditModel);
        }
        [HttpPost]
        public IActionResult Edit(StoreEditViewModel model)
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

                storeRepository.EditStore(store);
                return RedirectToAction("Details", new { id = model.Id });
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Store store = storeRepository.GetStore(id).Result;
            if (store == null)
            {
                ViewBag.ErrorMessage = $"Store with Id = {id} cannot be found";
                return View("NotFound"); 
            }
            else
            {
                storeRepository.DeleteStore(id);
                return RedirectToAction("Index");
            }
        }
    }
}