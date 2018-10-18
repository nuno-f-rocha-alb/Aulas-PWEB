using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcursoPesca;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pescadores = GestaoConcursoPesca.Pescadores;
            var tiposPeixe = GestaoConcursoPesca.TiposPeixe;


            // alinea A
            Console.WriteLine("--------Alinea A");
            var alineaA = tiposPeixe.OrderByDescending(x => x.Pontos).ThenBy(x => x.Tipo).ToList();
            foreach (var p in alineaA)
            {
                Console.WriteLine(p);
            }

            // alinea B
            Console.WriteLine("\n--------Alinea B");
            var alineaB = tiposPeixe.Max(x => x.Pontos);
            Console.WriteLine("Pontos: " + alineaB);

            // alinea C
            Console.WriteLine("\n--------Alinea C");
            var alineaC = tiposPeixe.First(x => x.Pontos == alineaB);
            Console.WriteLine(alineaC);

            // alinea D
            Console.WriteLine("\n--------Alinea D");
            Console.WriteLine("Peixe Premium: " + alineaA.ElementAt(0));
            foreach (var p in alineaA.Skip(1).Take(4))
            {
                Console.WriteLine(p);
            }


            // alinea E
            Console.WriteLine("\n--------Alinea E");
            var alineaE = pescadores.OrderByDescending(p => p.Pontuacao);
            foreach (var p in alineaE)
            {
                Console.WriteLine(p);
            }
            


            // alinea F
            Console.WriteLine("\n--------Alinea F");
            var alineaF = alineaE.First();
            Console.WriteLine(alineaF);

            // alinea G
            Console.WriteLine("\n--------Alinea G");
            var alineaG = pescadores.Where(p => p.Pescaria.Count == 0);
            foreach (var p in alineaG)
            {
                Console.WriteLine(p);
            }

            // alinea H
            Console.WriteLine("\n--------Alinea H");
            var alineaH = (float) pescadores.SelectMany(p => p.Pescaria).Sum(p => p.Peso) / 100;
            Console.WriteLine("Kilos: "+ alineaH);

            // alinea I
            Console.WriteLine("\n--------Alinea I");
            var alineaI = pescadores.SelectMany(p => p.Pescaria).GroupBy(p => p.Tipo).Select(p => new
            {
                tipo = p.Key.Tipo,
                totalPeso = p.Sum(x => x.Peso)
            });
            foreach (var p in alineaI)
            {
                Console.WriteLine(p.tipo + ":" + p.totalPeso);
            }

            // alinea J
            Console.WriteLine("\n--------Alinea J");
            var alineaJ = alineaI.OrderByDescending(p => p.totalPeso).First();
            Console.WriteLine(alineaJ);

            // alinea K
            Console.WriteLine("\n--------Alinea K");
            foreach (var p in pescadores)
            {
                var alineaK = p.Pescaria.Count() == 0 ? 0 : p.Pescaria.Average(x => x.Peso);
                Console.WriteLine($"{p} Media Peso = {alineaK}");
            }

            Console.ReadKey();
        }
    }
}
