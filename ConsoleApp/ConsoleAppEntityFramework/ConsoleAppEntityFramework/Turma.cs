using System.Collections.Generic;

namespace ConsoleAppEntityFramework
{
    class Turma
    {
        public int TurmaID { get; set; }

        public int Vagas { get; set; }

        public Professor Professor { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}
