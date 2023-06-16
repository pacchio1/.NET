using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_PrestitiBiblioteca.Models;

namespace MVC_PrestitiBiblioteca.Controllers
{
    [Authorize]
    public class StudentiController : Controller
    {
        private PrestitiBibliotecaContext db = new PrestitiBibliotecaContext();

        [AllowAnonymous]
        // GET: Studenti
        public ActionResult Index()
        {
            return View(db.Studenti.ToList()); 
        }

        // GET: Studenti/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studente studente = db.Studenti.Find(id);
            if (studente == null)
            {
                return HttpNotFound();
            }
            return View(studente);
        }

        // GET: Studenti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studenti/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Matricola,Nome,Cognome,Email,Classe")] Studente studente)
        {
            if (ModelState.IsValid)
            {
                db.Studenti.Add(studente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studente);
        }

        // GET: Studenti/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studente studente = db.Studenti.Find(id);
            if (studente == null)
            {
                return HttpNotFound();
            }
            return View(studente);
        }

        // POST: Studenti/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Matricola,Nome,Cognome,Email,Classe")] Studente studente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studente);
        }

        // GET: Studenti/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studente studente = db.Studenti.Find(id);
            if (studente == null)
            {
                return HttpNotFound();
            }
            return View(studente);
        }

        // POST: Studenti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Studente studente = db.Studenti.Find(id);
            db.Studenti.Remove(studente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
