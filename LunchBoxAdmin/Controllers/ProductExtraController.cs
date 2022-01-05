using LunchBox.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchBox.Admin.Controllers
{
    public class ProductExtraController : Controller
    {
        private readonly IProductExtraItemsRepository productExtraItemsRepository;

        public ProductExtraController(IProductExtraItemsRepository productExtraItemsRepository)
        {
            this.productExtraItemsRepository = productExtraItemsRepository;
        }

        public async Task<ViewResult> Index()
        {
            var model = await productExtraItemsRepository.GetProductExtraItems();
            return View(model);
        }
    }
}


