using MVC_Database_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Database_2.Controllers
{
    public class StudentiController : Controller
    {
        // GET: Studenti
        AnagraficaEntities db = new AnagraficaEntities();
        public ActionResult Index()
        {
            var studenti = db.Studenti.ToList();
            return View(studenti);
        }
    }
}