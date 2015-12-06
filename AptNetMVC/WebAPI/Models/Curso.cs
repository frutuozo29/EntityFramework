using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Curso
    {
        static int contador;

        public Curso()
        {
            Curso.contador++;
            this.Id = contador;
        }

        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}