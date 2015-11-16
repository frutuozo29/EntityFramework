using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConsoleAppEntityFramework
{
    class AppContext : DbContext
    {
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public AppContext() : base("Escola")
        {

        }

    }
}
