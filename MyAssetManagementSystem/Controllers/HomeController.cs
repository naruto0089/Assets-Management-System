﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyAssetManagementSystem.Models;

namespace MyAssetManagementSystem.Controllers
{
	public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

       
    }
}
