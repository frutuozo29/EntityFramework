using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Models
{
    public class Aluno
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
    }
}