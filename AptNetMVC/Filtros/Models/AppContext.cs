using System.Data.Entity;

namespace Filtros.Models
{
    public class AppContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public AppContext() : base("FiltrosDB")
        {

        }
    }
}