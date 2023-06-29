using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ludoteca.Models;

namespace Ludoteca.Controllers
{
    public class GiochiController : Controller
    {
        private readonly LudotecaContext _context;

        public GiochiController(LudotecaContext context)
        {
            _context = context;
        }

        // GET: Giochi
        public async Task<IActionResult> Index()
        {
              return _context.Giochi != null ? 
                          View(await _context.Giochi.ToListAsync()) :
                          Problem("Entity set 'LudotecaContext.Gioci'  is null.");
        }

        // GET: Giochi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Giochi == null)
            {
                return NotFound();
            }

            var gioco = await _context.Giochi
                .FirstOrDefaultAsync(m => m.IdGioco == id);
            if (gioco == null)
            {
                return NotFound();
            }

            return View(gioco);
        }

        // GET: Giochi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Giochi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Denominazione,Descrizione,Tipologia,EtaDeiGiocatori,NumeroDiGiocatori,DurataPartita,NumeroDiPezzi,IdGioco")] Gioco gioco)
        {
            
            
                _context.Add(gioco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            return View(gioco);
        }

        // GET: Giochi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Giochi == null)
            {
                return NotFound();
            }

            var gioco = await _context.Giochi.FindAsync(id);
            if (gioco == null)
            {
                return NotFound();
            }
            return View(gioco);
        }

        // POST: Giochi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Denominazione,Descrizione,Tipologia,EtaDeiGiocatori,NumeroDiGiocatori,DurataPartita,NumeroDiPezzi,IdGioco")] Gioco gioco)
        {
            if (id != gioco.IdGioco)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gioco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiocoExists(gioco.IdGioco))
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
            return View(gioco);
        }

        // GET: Giochi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Giochi == null)
            {
                return NotFound();
            }

            var gioco = await _context.Giochi
                .FirstOrDefaultAsync(m => m.IdGioco == id);
            if (gioco == null)
            {
                return NotFound();
            }

            return View(gioco);
        }

        // POST: Giochi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Giochi == null)
            {
                return Problem("Entity set 'LudotecaContext.Gioci'  is null.");
            }
            var gioco = await _context.Giochi.FindAsync(id);
            if (gioco != null)
            {
                _context.Giochi.Remove(gioco);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiocoExists(int id)
        {
          return (_context.Giochi?.Any(e => e.IdGioco == id)).GetValueOrDefault();
        }
        //get denominazione gioco
        public async Task<IActionResult> SearchByDeno(string SQ)
        {
            if (string.IsNullOrEmpty(SQ))
            {
                return RedirectToAction(nameof(Index));
            }
            var giochi=await _context.Giochi
                .Where(g => g.Denominazione.Contains(SQ))
                .ToListAsync();
            return View("Index",giochi);
        }
        
    }
}
