using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEx4
{
    class Program
    {
        

        static List<Pessoa> InserirPessoas()
        {
            List<Pessoa> escolaList = new List<Pessoa>();
            bool t = true;
            string n, h;
            int num;
            DateTime dt;
            while (t)
            {
                Console.WriteLine("adicionar aluno(1) ou professor(2)");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 0 :
                        t = false;
                        break;
                    case 1:
                        Console.Write("Nome: ");
                        n = Console.ReadLine();
                        Console.Write("Data: ");
                        dt = DateTime.Parse(Console.ReadLine());
                        Console.Write("Numero de aluno: ");
                        num = int.Parse(Console.ReadLine());
                        Pessoa a = new Aluno(num, n, dt);
                        escolaList.Add(a);
                        break;
                    case 2:
                        Console.Write("Nome: ");
                        n = Console.ReadLine();
                        Console.Write("Data: ");
                        dt = DateTime.Parse(Console.ReadLine());
                        Console.Write("Habilitacoes: ");
                        h = Console.ReadLine();
                        Pessoa te = new Professor(h, n, dt);
                        escolaList.Add(te);
                        break;
                    default:
                        break;
                }
            }


            return escolaList;
        }

        static void MostraPessoas(List<Pessoa> list)
        {
            foreach (var p in list)
            {
                MostraDadosPessoas(p);
            }
        }

        static void MostraDadosPessoas(Pessoa p)
        {
            Console.WriteLine(p.ToString());
        }

        static void Main(string[] args)
        {
            List<Pessoa> escolaList =  InserirPessoas();
            MostraPessoas(escolaList);
            Console.WriteLine("Next ID: " + Pessoa.getNextId);
            Console.ReadKey();
        }
    }
}
