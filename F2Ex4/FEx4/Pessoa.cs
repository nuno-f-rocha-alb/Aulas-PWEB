using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEx4
{
   abstract  class Pessoa
    {
        private string nome;
        private DateTime datanascimento;
        private static int idCounter = 0;
        private int id;

        public static int getNextId
        {
            get { return idCounter + 1; }
        }



        public Pessoa(string nome = "Desconhecido", DateTime datanascimento = new DateTime())
        {
            this.nome = nome;
            this.datanascimento = datanascimento;
            idCounter++;
            this.id = idCounter;
        }

        public string Nome { get => this.nome;}

        public DateTime Datanascimento
        {
            get { return this.datanascimento; }
            set
            {
                if (DateTime.Compare(value, new DateTime(1, 1, 0001)) == 0)
                {
                    throw new FormatException("Formato de Data Incorreto");
                }
                else if (DateTime.Compare(value, new DateTime(1900, 1, 1)) < 0 || DateTime.Compare(value, DateTime.Today) > 0)
                {
                    throw new ArgumentOutOfRangeException(null, "Data com valores fora dos parametros");
                }
                else
                {
                    datanascimento = value;
                }

            }
        }

        public override string ToString()
        {
            string str = "|" + this.Nome + "|" + this.Datanascimento + "|";
            return str;
        } 
    }
}
