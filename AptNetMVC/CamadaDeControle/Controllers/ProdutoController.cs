using CamadaDeControle.Models;
using System.Linq;
using System.Web.Mvc;

namespace CamadaDeControle.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Listar(double? precoMinimo, double? precoMaximo)
        {
            var ctx = new AppContext();
            var produtos = ctx.Produtos.AsEnumerable();

            if (precoMinimo != null && precoMaximo != null)
            {
                produtos = from p in produtos
                           where p.Preco >= precoMinimo & p.Preco <= precoMaximo
                           select p;
            }
            return View(produtos);
        }

        [HttpGet]
        public ActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastra(Produto p)
        {
            var ctx = new AppContext();
            ctx.Produtos.Add(p);
            ctx.SaveChanges();

            TempData["Mensagem"] = "Produto cadastrado com Sucesso";
            return RedirectToAction("Listar");
        }
    }
}