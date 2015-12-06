using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}