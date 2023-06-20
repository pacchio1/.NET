﻿using Core_Ludoteca.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Core_Ludoteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //giochi
        public IActionResult Giochi()
        {
            return View();
        }
        //Prestiti
        public IActionResult Prestiti()
        {
            return View();
        }
    }
}