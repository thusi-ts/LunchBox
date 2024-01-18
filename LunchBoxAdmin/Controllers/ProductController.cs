﻿using LunchBoxAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<ViewResult> Index()
        {
            var model = await productRepository.GetProductsList(1);
            return View(model);
        }

        [HttpPost]
        public async Task<ViewResult> Index(int currentPageIndex)
        {
            var model = await productRepository.GetProductsList(currentPageIndex);
            return View(model);
        }
    }
}
