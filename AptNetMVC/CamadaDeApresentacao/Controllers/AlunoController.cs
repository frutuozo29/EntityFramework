using CamadaDeApresentacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Aluno()
        {
            Aluno aluno = new Aluno
            {
                Nome = "Renan Frutuozo",
                Email = "frutuozo29@gmail.com"
            };
            return View(aluno);
        }


        public ActionResult Listar()
        {
            ICollection<Aluno> lista = new List<Aluno>();

            for (int i = 0; i < 10; i++)
            {
                Aluno aluno = new Aluno
                {
                    Id = i,
                    Nome = "Aluno " + i.ToString(),
                    Email = "emailaluno" + i.ToString() + "@gmail.com"
                };
                lista.Add(aluno);
            }
            return View(lista);
        }

        public ActionResult Editar()
        {
            Aluno aluno = new Aluno
            {
                Id = 1,
                Nome = "Renan Frutuozo",
                Email = "frutuozo29@gmail.com" 
            };
            return View(aluno);
        }

    }
}