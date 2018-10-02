using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEx4
{
    class Professor : Pessoa
    {
        private string habilitacoes;

        public Professor(string habilitacoes, string nome = "ProfessorDesconhecido", DateTime datanascimento = new DateTime()) : base(nome, datanascimento)
        {
            this.habilitacoes = habilitacoes;
        }

        public string Habilitacoes { get => this.habilitacoes;}

        public override string ToString()
        {
            return base.ToString() + this.Habilitacoes + "|";
        }
    }
}
