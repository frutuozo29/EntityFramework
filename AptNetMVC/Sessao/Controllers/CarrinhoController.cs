using Sessao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sessao.Controllers
{
    public class CarrinhoController : Controller
    {
        private AppContext db = new AppContext();

        // GET: Carrinho
        public ActionResult Index()
        {
            return View(this.PegaCarrinhoDaSessao());
        }

        public ActionResult Cancelar()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Produto");
        }

        public ActionResult Adicionar(int id = 0)
        {
            var p = db.Produtos.Find(id);

            if (p == null)
            {
                return HttpNotFound();
            }

            var carrinho = this.PegaCarrinhoDaSessao();
            carrinho.Produtos.Add(p);

            TempData["Mensagem"] = "Produto incluido com sucesso!";

            return RedirectToAction("Index", "Produto");
        }

        public ActionResult Remover(int id = 0)
        {
            var carrinho = this.PegaCarrinhoDaSessao();
            carrinho.Produtos.RemoveAt(id);

            TempData["Mensagem"] = "Removido do carrinho com Sucesso!";

            return RedirectToAction("Index", "Produto");
        }

        private Carrinho PegaCarrinhoDaSessao()
        {
            if (Session["Carrinho"] == null)
            {
                Session["Carrinho"] = new Carrinho();
            }

            return Session["Carrinho"] as Carrinho;
        }
    }
}