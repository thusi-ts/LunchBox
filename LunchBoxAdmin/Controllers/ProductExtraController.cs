﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Controllers
{
    public class ProductExtraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
