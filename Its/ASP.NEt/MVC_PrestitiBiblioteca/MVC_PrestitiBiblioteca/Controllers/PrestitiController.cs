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
    public class PrestitiController : Controller
    {
        private PrestitiBibliotecaContext db = new PrestitiBibliotecaContext();

        // GET: Prestiti
        public ActionResult Index()
        {
            var prestiti = db.Prestiti.Include(p => p.Libro).Include(p => p.Studente);
            return View(prestiti.ToList());
        }

        // GET: Prestiti/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestito prestito = db.Prestiti.Find(id);
            if (prestito == null)
            {
                return HttpNotFound();
            }
            return View(prestito);
        }

        // GET: Prestiti/Create
        public ActionResult Create()
        {
            ViewBag.IdLibro = new SelectList(db.Libri, "Codice", "Autore");
            ViewBag.Matricola = new SelectList(db.Studenti, "Matricola", "Nome");
            return View();
        }

        // POST: Prestiti/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdLibro,Matricola,DataPrestito,DataRestituzione")] Prestito prestito)
        {
            if (ModelState.IsValid)
            {
                db.Prestiti.Add(prestito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdLibro = new SelectList(db.Libri, "Codice", "Autore", prestito.IdLibro);
            ViewBag.Matricola = new SelectList(db.Studenti, "Matricola", "Nome", prestito.Matricola);
            return View(prestito);
        }

        // GET: Prestiti/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestito prestito = db.Prestiti.Find(id);
            if (prestito == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdLibro = new SelectList(db.Libri, "Codice", "Autore", prestito.IdLibro);
            ViewBag.Matricola = new SelectList(db.Studenti, "Matricola", "Nome", prestito.Matricola);
            return View(prestito);
        }

        // POST: Prestiti/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdLibro,Matricola,DataPrestito,DataRestituzione")] Prestito prestito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prestito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdLibro = new SelectList(db.Libri, "Codice", "Autore", prestito.IdLibro);
            ViewBag.Matricola = new SelectList(db.Studenti, "Matricola", "Nome", prestito.Matricola);
            return View(prestito);
        }

        // GET: Prestiti/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestito prestito = db.Prestiti.Find(id);
            if (prestito == null)
            {
                return HttpNotFound();
            }
            return View(prestito);
        }

        // POST: Prestiti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prestito prestito = db.Prestiti.Find(id);
            db.Prestiti.Remove(prestito);
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
