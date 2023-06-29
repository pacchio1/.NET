using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core_PrestitiVideoteca.Models;

namespace Frontend.PrestitiVideoteca.Controllers
{
    public class PrestitiController : Controller
    {
        private Core_PrestitiVideotecaContext db=new Core_PrestitiVideotecaContext();

        public async Task<IActionResult> PrestitiEffettuati(int? id)
        {
            if (id == null || db.Films == null)
            {
                return NotFound();
            }

            var film = await db.Films
                .FirstOrDefaultAsync(m => m.Codice == id);
            if (film == null)
            {
                return NotFound();
            }

            var prestiti = await db.Prestiti
                .Include(p => p.Matricola)
                .Where(p => p.IdFilm == id)
                .ToListAsync();

            ViewBag.Film = film;
            return View(prestiti);
        }

        public PrestitiController(Core_PrestitiVideotecaContext context)
        {
            db = context;
        }

        // GET: Prestiti
        public async Task<IActionResult> Index()
        {
            var core_PrestitiVideotecaContext = db.Prestiti.Include(p => p.IdFilmNavigation).Include(p => p.MatricolaNavigation);
            return View(await core_PrestitiVideotecaContext.ToListAsync());
        }

        // GET: Prestiti/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || db.Prestiti == null)
            {
                return NotFound();
            }

            var prestito = await db.Prestiti
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestito == null)
            {
                return NotFound();
            }

            return View(prestito);
        }

        // GET: Prestiti/Create
        public IActionResult Create()
        {
            ViewData["IdFilm"] = new SelectList(db.Films, "Codice", "Codice");
            ViewData["Matricola"] = new SelectList(db.Studenti, "Matricola", "Matricola");
            return View();
        }

        // POST: Prestiti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdFilm,Matricola,DataPrestito,DataRestituzione")] Prestito prestito)
        {
            if (ModelState.IsValid)
            {
                db.Add(prestito);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFilm"] = new SelectList(db.Films, "Codice", "Codice", prestito.IdFilm);
            ViewData["Matricola"] = new SelectList(db.Studenti, "Matricola", "Matricola", prestito.Matricola);
            return View(prestito);
        }

        // GET: Prestiti/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || db.Prestiti == null)
            {
                return NotFound();
            }

            var prestito = await db.Prestiti.FindAsync(id);
            if (prestito == null)
            {
                return NotFound();
            }
            ViewData["IdFilm"] = new SelectList(db.Films, "Codice", "Codice", prestito.IdFilm);
            ViewData["Matricola"] = new SelectList(db.Studenti, "Matricola", "Matricola", prestito.Matricola);
            return View(prestito);
        }

        // POST: Prestiti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdFilm,Matricola,DataPrestito,DataRestituzione")] Prestito prestito)
        {
            if (id != prestito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(prestito);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestitoExists(prestito.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFilm"] = new SelectList(db.Films, "Codice", "Codice", prestito.IdFilm);
            ViewData["Matricola"] = new SelectList(db.Studenti, "Matricola", "Matricola", prestito.Matricola);
            return View(prestito);
        }

        // GET: Prestiti/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || db.Prestiti == null)
            {
                return NotFound();
            }

            var prestito = await db.Prestiti
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestito == null)
            {
                return NotFound();
            }

            return View(prestito);
        }

        // POST: Prestiti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (db.Prestiti == null)
            {
                return Problem("Entity set 'Core_PrestitiVideotecaContext.Prestiti'  is null.");
            }
            var prestito = await db.Prestiti.FindAsync(id);
            if (prestito != null)
            {
                db.Prestiti.Remove(prestito);
            }
            
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestitoExists(int id)
        {
          return (db.Prestiti?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
