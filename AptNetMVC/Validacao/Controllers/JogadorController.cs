using System.Web.Mvc;
using Validacao.Models;

namespace Validacao.Controllers
{
    public class JogadorController : Controller
    {
        // GET: Jogador
        public ActionResult Listar()
        {
            var ctx = new AppContext();
            return View(ctx.Jogadores);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador j)
        {
            if (ModelState.IsValid)
            {
                var ctx = new AppContext();
                ctx.Jogadores.Add(j);
                ctx.SaveChanges();
                return RedirectToAction("Listar");
            }
            else
            {
                return View("Cadastrar", j);
            }
        }
    }
}