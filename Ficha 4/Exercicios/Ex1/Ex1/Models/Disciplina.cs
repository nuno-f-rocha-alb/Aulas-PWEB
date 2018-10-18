namespace Ex1.Models
{
    public class Disciplina
    {
        public int id;
        public string nome;
        public string descricao;

        public Disciplina(int id, string nome, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
        }
    }
}