using System.Collections.Generic;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new AppContext())
            {
                var aluno1 = new Aluno
                {
                    Nome = "Renan Frutuozo",
                    Endereco = new Endereco
                    {
                        Logradouro = "Avenida XXVI",
                        CEP = "61800000",
                        Numero = 402
                    }
                };

                var aluno2 = new Aluno
                {
                    Nome = "Rodolffo Frutuozo",
                    Endereco = new Endereco
                    {
                        Logradouro = "Teresina",
                        CEP = "42500690",
                        Numero = 2526
                    }
                };


                var professor = new Professor
                {
                    Nome = "Ribeiro Batista",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua da Pindaiba",
                        CEP = "69500000",
                        Numero = 700
                    }
                };

                var turma = new Turma
                {
                    Vagas = 2,
                    Alunos = new List<Aluno>()
                };


                turma.Professor = professor;
                turma.Alunos.Add(aluno1);
                turma.Alunos.Add(aluno2);

                ctx.Turmas.Add(turma);
                ctx.SaveChanges();
            }

        }
    }
}
