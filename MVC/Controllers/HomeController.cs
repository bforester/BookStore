﻿using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
