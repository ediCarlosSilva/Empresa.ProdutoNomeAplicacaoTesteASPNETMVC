using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empresa.ProdutoNomeAplicacaoTesteASPNETMVC.Web.Controllers
{
    public class FrasesController : Controller
    {
        // GET: Frases
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string frase)
        {
            ViewBag.Frase = frase;
            return View("Confirmacao");
        }
    }
}