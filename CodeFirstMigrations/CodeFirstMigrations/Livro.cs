namespace CodeFirstMigrations
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public int EditoraId { get; set; }
        public Editora Editora { get; set; }
    }
}
