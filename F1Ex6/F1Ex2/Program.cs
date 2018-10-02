using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public List<Tarefa> ListarTarefas(List<Tarefa> list)
        {
            list.OrderBy(o => o.Prioridade).ThenBy(o => o.Indice).ToList();
            return list;
        }

        public List<Tarefa> tarefasEmAtraso(List<Tarefa> list)
        {
            Func<Tarefa, bool> isEmAtraso = t => t.DataLimite < DateTime.Today && t.Estado != Estado.Concluida;
            List<Tarefa> ListadetarefasEmAtraso = list.Where(isEmAtraso).ToList<Tarefa>();
            return ListadetarefasEmAtraso;
        }

        public void apagarTarefasConcluidas(List<Tarefa> list)
        {
            list.RemoveAll(x => x.Estado == Estado.Concluida);
        }

    }
}
