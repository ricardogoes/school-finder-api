namespace SchoolFinder.Domain.Common.Entities
{
    public class Estado
    {       
        public int Id { get; private set; }
        public int RegiaoId { get; private set; }
        public string Nome { get; private set; }

        public Estado(int id, int regiaoId, string nome)
        {
            Id = id;
            RegiaoId = regiaoId;
            Nome = nome;
        }
    }
}
