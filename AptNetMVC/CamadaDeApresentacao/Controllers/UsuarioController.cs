using CamadaDeApresentacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Editar()
        {

            Usuario usuario = new Usuario
            {
                Id = 1,
                Nome = "Renan Frutuozo",
                Email = "frutuozo29@gmail.com",
                Senha = "123",
                Descricao = "Developer at Fortes Tecnologia",
                DataDeCadastro = DateTime.Now
            };
            return View(usuario);
        }
    }
}