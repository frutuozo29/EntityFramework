using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstMigrations
{
    public class Editora
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome não pode ser Vazio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Email não pode ser Vazio")]
        public string Email { get; set; }
        public string Telefone { get; set; }

        [ForeignKey("EditoraId")]
        public virtual IList<Livro> Livros { get; set; }
    }
}
