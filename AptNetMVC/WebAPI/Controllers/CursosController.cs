using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CursosController : ApiController
    {

        private static List<Curso> cursos = new List<Curso>
        {
            new Curso
            {
                Sigla = "ADS",
                Nome = "Analise e Desenvolvimento de Sistemas"
            },
            new Curso
            {
                Sigla = "MED",
                Nome = "Medicina"
            }
        };

        public List<Curso> Get()
        {
            return cursos;
        }

        public Curso Get(int id)
        {
            Curso curso = cursos.Find(c => c.Id == id);
            return curso;
        }

        public Curso Get(string sigla)
        {
            Curso curso = cursos.Find(c => c.Sigla == sigla);
            return curso;
        }

        public void Post(Curso curso)
        {
            cursos.Add(curso);
        }

    }
}
