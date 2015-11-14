
namespace CodeFirstMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AppContext ctx = new AppContext())
            {

                Editora ed = new Editora
                {                
                    Nome = "Positivo",
                    Email = "Positivo@gmail.com"
                };

                ctx.Editoras.Add(ed);
                ctx.SaveChanges();
            }
        }
    }
}
