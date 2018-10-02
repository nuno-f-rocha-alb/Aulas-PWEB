using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Ex2
{
    enum Prioridade { Baixa, Normal, Alta}
    enum Categoria { Pessoal, trabalho }
    enum Estado { Porexecutar, emExecucao, Concluida}
    class Tarefa
    {
        private string titulo;
        private DateTime dataLimite;
        private static int nindice = 0;
        private int indice;

        public Tarefa(string titulo, DateTime dataLimite, Prioridade prioridade = Prioridade.Alta, Estado estado = Estado.Porexecutar, Categoria categoria = Categoria.trabalho)
        {
            Prioridade = prioridade;
            Estado = estado;
            Categoria = categoria;

            Titulo = titulo;
            DataLimite = dataLimite;

            nindice++;
            Indice = nindice;
            

        }

        public Prioridade Prioridade { get; set; }
        public Estado Estado { get; set; }
        public Categoria Categoria { get; set; }
        public string Titulo { get; set; }
        public DateTime DataLimite { get; set; }
        public int Indice { get; set; }

    }
}
