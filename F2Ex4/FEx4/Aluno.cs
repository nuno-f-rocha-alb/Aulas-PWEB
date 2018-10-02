using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEx4
{
    class Aluno : Pessoa
    {
        private int naluno;

        public Aluno(int naluno, string nome = "AlunoDesconhecido", DateTime datanascimento = new DateTime()) : base(nome, datanascimento)
        {
            this.naluno = naluno;
        }

        public int Naluno { get => this.naluno;}

        public override string ToString()
        {
            return base.ToString() + this.Naluno + "|";
        }
    }
}
