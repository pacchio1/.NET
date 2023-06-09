using MVC_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Database.Controllers
{
    public class StudentiController : Controller
    {
         AnagraficaEntities1 db=new AnagraficaEntities1();
        // GET: Studenti
        public ActionResult Index()
        {
            //lista studenti
            var studenti = db.Studenti.ToList();
            return View(studenti);
        }
    }
}