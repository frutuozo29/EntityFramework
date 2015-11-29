using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Validacao.Models
{
    public class Jogador
    {
        [HiddenInput(DisplayValue = false)]
        public int JogadorID { get; set; }
        
        [Required(ErrorMessage = "O Nome do Jogador é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Número do jogador é obrigatório")]
        [Range(1, 99, ErrorMessage = "A Altura do jogador deve ser maior que 0 e menor que 100.")]
        public int? Numero { get; set; }

        [Required(ErrorMessage = "A Altura do jogador é obrigatória")]
        [Range(0, double.MaxValue, ErrorMessage = "A altura do jogador deve ter um valor positivo")]
        public double? Altura { get; set; }
    }
}