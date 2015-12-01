using Filtros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filtros.Controllers
{
    public class AutenticadorController : Controller
    {
        public ActionResult Formulario()
        {
            return View();
        }


        public ActionResult Entrar(Usuario usuario)
        {
            if (usuario.Username != null && usuario.Password != null &&
                usuario.Username.Equals("admin") && usuario.Password.Equals("123"))
            {
                FormsAuthentication.SetAuthCookie(usuario.Username, false);
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Mensagem = "Usuário incorreto";
                return View("Formulario");
            }
        }

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            return View("Formulario");
        }
    }
}