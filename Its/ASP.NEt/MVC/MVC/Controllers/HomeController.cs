using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChiSiamo()
        {
            ViewBag.Messaggio = "Sezione Chi Siamo"; 
            ViewData["Informazioni"] = "ASP.Net MVC - via le mani dal naso 69- 10420 Torino";

            return View();
        }
        public ActionResult Contatti()
        {
            var contatti= new ContattiViewModel();

            return View(contatti);
        }
        public ActionResult RecuperoContatti(ContattiViewModel contatto)
        {
           if (contatto == null) 
            { return  new HttpStatusCodeResult(HttpStatusCode.BadRequest); }
           else { return View(); }

           
        }
    }
}