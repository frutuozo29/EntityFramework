using System.Data.Entity;

namespace CustomizationCodeFirstMigrations
{
    class AppContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
