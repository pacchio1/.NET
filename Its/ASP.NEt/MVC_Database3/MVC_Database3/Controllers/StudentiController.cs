using LinqToXml;
using Microsoft.Ajax.Utilities;
using MVC_Database3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Database3.Controllers
{
    public class StudentiController : Controller
    {
        //private MVC_AnagraficaEntities db = new MVC_AnagraficaEntities();
        private AnagraficaContext Context=new AnagraficaContext();
        // GET: Studenti
        public ActionResult Index()
        {
            var elenco_studenti = Context.Studenti.OrderBy(s => s.Cognome).OrderBy(s => s.Nome).ToList();
            return View(elenco_studenti);

        }
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            var studente = Context.Studenti.Find(id);
            if (studente == null)
                return HttpNotFound();
            return View(studente);

        }
        //create
        //get
        public ActionResult Create()
        {             
            return View();
        }
        //post
        [HttpPost]
        public ActionResult Create(Studenti studente)
        {
            if (ModelState.IsValid) {
                Context.Studenti.Add(studente);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(); 
        }
        //Edit
        //get
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var studente = Context.Studenti.Find(id);
            if (studente == null)
                return HttpNotFound();
            return View(studente);
        }
        //post
        [HttpPost]
        public ActionResult Edit(Studenti studente)
        {
            if (ModelState.IsValid)
            {
                Context.Entry(studente).State=System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studente);
        }
        //Delete
        //get
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var studente = Context.Studenti.Find(id);
            if (studente == null)
                return HttpNotFound();
            return View(studente);
        }
        //post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            var studente=Context.Studenti.Find(id);
            Context.Studenti.Remove(studente);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}