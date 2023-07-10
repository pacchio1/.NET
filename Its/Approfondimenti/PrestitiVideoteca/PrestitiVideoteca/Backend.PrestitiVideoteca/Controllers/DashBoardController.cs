using Core_PrestitiVideoteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend.PrestitiVideoteca.Controllers
{
    [Authorize(Roles ="Administrators")]
    public class DashBoardController : Controller
    {
        private Core_PrestitiVideotecaContext db = new Core_PrestitiVideotecaContext();
        public IActionResult Index()
        {
            ViewBag.NumeroPrestitiAttivi = db.Prestiti.Where(p => p.DataRestituzione == null).Count();
            
            return View();
        }
    }
}
