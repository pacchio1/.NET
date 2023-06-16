using Core_Example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Core_Example.Controllers
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
        public IActionResult Information()
        {
            ViewBag.Text = "Informazioni";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Lampadina(Lampadina l)
        {
            l.Stato = 0;
            l.Nutilizi= 2;
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}