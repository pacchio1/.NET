using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core_PrestitiVideoteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Frontend.PrestitiVideoteca.Controllers
{
    public class FilmsController : Controller
    {
        private readonly Core_PrestitiVideotecaContext _context;

        public FilmsController(Core_PrestitiVideotecaContext context)
        {
            _context = context;
        }

        // GET: Films
        public async Task<IActionResult> Index(string searchAll, string searchGenere, string orderbyTitolo, int pagina=1)
        {
            int numeroPerPagina = 100;
            var lista = _context.Films
                .Skip(numeroPerPagina * (pagina - 1))
                .Take(numeroPerPagina)

                    ;
            ViewBag.Pagina = pagina;
            ViewBag.NumeroPerPagina = numeroPerPagina;
            ViewBag.NumeroRecord = _context.Films.Count();

             return _context.Films != null ? 
                          View(await lista.ToListAsync()) :
                          Problem("Entity set 'Core_PrestitiVideotecaContext.Films'  is null.");
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Films == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .FirstOrDefaultAsync(m => m.Codice == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ConfermaPrestito(int? id)
        {
            if (id == null || _context.Films == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .FirstOrDefaultAsync(m => m.Codice == id);
            if (film == null)
            {
                return NotFound();
            }

            var studente = _context.Studenti.Where(s => s.Email.Equals(User.Identity.Name)).FirstOrDefault();

            var prestito = new Prestito
            {
                DataPrestito = DateTime.Now,
                IdFilm = film.Codice,
                Matricola = studente.Matricola
            };
            
            try
            {
                _context.Prestiti.Add(prestito);
                _context.SaveChanges();

                ViewBag.Messaggio = "La tua richiesta è stata presa in carico";

            }
            catch (Exception ex) {
                ViewBag.Messaggio = $"Si è verificato un errore! {ex.Message}";
            }

            return View();
        }
        private bool FilmExists(int id)
        {
          return (_context.Films?.Any(e => e.Codice == id)).GetValueOrDefault();
        }
    }
}
