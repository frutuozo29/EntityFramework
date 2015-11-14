using System.ComponentModel.DataAnnotations;

namespace CustomizationCodeFirstMigrations
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "É necessario informar um TelefoneFixo")]
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }

    }
}
