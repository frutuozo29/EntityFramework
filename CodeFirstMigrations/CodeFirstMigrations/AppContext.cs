using System;
using System.Data.Entity;

namespace CodeFirstMigrations
{
    public class AppContext : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
        
    }
}
