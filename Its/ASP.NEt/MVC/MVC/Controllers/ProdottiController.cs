using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VenditaProdotti;

namespace MVC.Controllers
{
    public class ProdottiController : Controller
    {
        // GET: Prodotti
        public ActionResult Index()
        {
            var prodotto = new Prodotto { 
                Coice=1,
                Descrizione="1",
                Nome="1",
                Prezzo=3.0,
                Giacenza=8
            };
            return View(prodotto);
        }
    }
}