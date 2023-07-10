using Core_PrestitiVideoteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frontend.PrestitiVideoteca.Controllers
{
    [Authorize]
    public class PrestitiController : Controller
    {
        private Core_PrestitiVideotecaContext db = new Core_PrestitiVideotecaContext();
        public IActionResult Index()
        {
            var studente = db.Studenti.Where(s => s.Email == User.Identity.Name).FirstOrDefault();
            var lista = db.Prestiti
                .Where(x => x.Matricola == studente.Matricola)
                .OrderByDescending(x=>x.DataPrestito)
                .Include(x=> x.IdFilmNavigation) //recupero dati dei film in relazione con il prestito
                .Include(x => x.MatricolaNavigation) //recupero dati dello studente in relazione con il prestito
                .ToList();

            return View(lista);
        }
    }
}
