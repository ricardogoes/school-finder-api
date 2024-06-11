namespace SchoolFinder.Domain.Common.Entities
{
    public class Regiao
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Regiao(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
