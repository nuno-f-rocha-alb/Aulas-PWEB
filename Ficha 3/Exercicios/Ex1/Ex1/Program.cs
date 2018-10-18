using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] PWLista =
            {
                "C#", "Aprender C#", "ASP.NET MVC com C#",
                "Entity Framework", "Bootstrap", "Identity",
                "Lambda", "Delegates", "Linq", "POO com C# "
            };



            string[] PWLista2 =
            {
                "C#", "ASP.NET MVC",
                "Linq", "Lambda e C#"
            };

            int[] PWNum = {10, 23, 54, 77, 85, 12, 1, 4, 53};

            //alineaD(PWLista);
            //alineaG(PWNum);
            //alineaI(PWLista, PWLista2);
            //alineaK(PWNum);
            alineaL(PWLista);
            Console.ReadKey();
        }

        static void alineaA(string[] list)
        {
            var lista = list.OrderBy(l => l).ToList();
            foreach (var l in lista)
            {
                Console.WriteLine(l);
            }

        }

        static void alineaB(string[] list)
        {
            var lista = list.Where(l => l.Length < 6).Select(l => l).ToList();
            foreach (var l in lista)
            {
                Console.WriteLine(l);
            }
        }
        static void alineaC(string[] list)
        {
            var lista = list.Count(l => l.Contains("C#"));
            Console.Write(lista);
        }

        static void alineaD(string[] list)
        {

            var palavras = list.Select(x => x.Trim().Split(' ').Count()).ToList();
            foreach (var n in palavras)
            { 

                Console.Write(n + ",");
            }
            
        }

        static void alineaE(int[] vec)
        {
            var media = vec.Average();
            Console.Write(media);
        }
        static void alineaF(int[] vec)
        {
            var max = vec.Max();
            Console.Write(max);
        }

        static void alineaG(int[] vec)
        {
            var ordem = vec.Where(x => x >= 1 && x <= 25).OrderByDescending(x => x).ToArray();
            foreach (var i in ordem)
            {
                Console.Write(i + ",");
            }
        }

        static void alineaH(string[] list, string[] list2)
        {
            var res = list.Intersect(list2).ToList();
            foreach (var VARIABLE in res)
            {
                Console.Write(VARIABLE + " ");
            }
        }

        static void alineaI(string[] list, string[] list2)
        {
            var res = list.Union(list2).ToList();
            foreach (var VARIABLE in res)
            {
                Console.WriteLine(VARIABLE + " ");
            }
        }

        static void alineaJ(int[] vec)
        {

            var solucao = vec.GroupBy(x => x % 2);
            foreach (var x in solucao)
            {
                Console.WriteLine();
                Console.Write(x.Key==0?"Numeros Pares: " : "Numeros Impares: ");
                foreach (var y in x)
                {
                    Console.Write(y + " ");
                }
            }
        }

        static void alineaK(int[] vec)
        {
            var result = vec.Where(x => x <= 30).Aggregate((a, b) => a * b);
            Console.Write(result);
        }

        static void alineaL(string[] list)
        {

            var solucao = list.Where(s => s.Contains("C#")).Select(s => new
            {
                str = s.Trim(),
                sInicial = s.Trim().Split(' ').First(),
                sFinal = (s.Trim().Split(' ')).Count() ==1? "NAO TEM" : s.Trim().Split(' ').Last()

            });
            foreach (var s in solucao)
            {
                Console.WriteLine("String: " + s.str + "\n\tPrimeira Palavra: " + s.sInicial + "\n\tUltima Palavra: " + s.sFinal);
            }
        }
    }
}
