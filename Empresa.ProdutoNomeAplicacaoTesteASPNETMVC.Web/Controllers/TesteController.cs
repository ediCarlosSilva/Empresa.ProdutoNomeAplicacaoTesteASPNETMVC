using Empresa.ProdutoNomeAplicacaoTesteASPNETMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empresa.ProdutoNomeAplicacaoTesteASPNETMVC.Web.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View(new Pessoa());
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            return View("Saudacao", pessoa);
        }
    }
}