namespace CustomizationCodeFirstMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                var pessoa = new Pessoa
                {
                    Nome = "Renan Frutuozo",
                    TelefoneCelular = "(85) 9 8832-0829",
                    Email = "frutuozo29@gmail.com",
                    TelefoneFixo = "(85) 3384-6237"
                };

                db.Pessoas.Add(pessoa);
                db.SaveChanges();
            }
        }
    }
}
