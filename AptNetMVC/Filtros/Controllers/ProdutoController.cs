using Filtros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Controllers
{
    public class ProdutoController : Controller
    {

        private AppContext db = new AppContext();

        public ActionResult Index()
        {
            return View(db.Produtos.ToList());
        }

        [Authorize]
        public ActionResult Cadastrar()
        {
            if (Session["Usuario"] != null)
            {
                return View();
            }
            else
            {
                TempData["Mensagem"] = "É necessário se autenticar.";
                return RedirectToAction("Index");    
            }
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto p)
        {
            if (ModelState.IsValid)
            {
                db.Produtos.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}