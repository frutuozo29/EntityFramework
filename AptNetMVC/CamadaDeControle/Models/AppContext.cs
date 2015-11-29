using System.Data.Entity;

namespace CamadaDeControle.Models
{
    public class AppContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}