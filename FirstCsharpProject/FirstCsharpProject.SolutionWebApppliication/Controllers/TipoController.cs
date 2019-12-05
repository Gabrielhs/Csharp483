using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharp483.Dados;
using CSharp483.Dados.Repositorio;

namespace FirstCsharpProject.SolutionWebApppliication.Controllers
{
    public class TipoController : Controller
    {
        // GET: Tipo
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Tipo model)
        {
            TipoRepositorio reposito = new TipoRepositorio();
            reposito.Iserir(model);
            ModelState.Clear();
            return RedirectToAction("Index");
        }
    }
}