﻿using Microsoft.AspNetCore.Mvc;

namespace WepApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
