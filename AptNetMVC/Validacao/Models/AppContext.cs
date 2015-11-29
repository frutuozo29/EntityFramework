using System.Data.Entity;
namespace Validacao.Models
{
    public class AppContext : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }

        public AppContext() : base("ValidacaoDB")
        {

        }
    }
}