using System.Data.Entity;

namespace Sessao.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("SessaoDB") { }

        public DbSet<Produto> Produtos { get; set; }
    }
}