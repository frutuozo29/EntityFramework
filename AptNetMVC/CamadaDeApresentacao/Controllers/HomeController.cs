using System;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Random radom = new Random();
            ViewBag.NumeroDaSorte = radom.Next();
            return View();
        }
    }
}