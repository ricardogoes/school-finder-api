namespace SchoolFinder.Domain.Common.Entities
{
    public class Bairro
    {
        public long Id { get; private set; }
        public long CidadeId { get; set; }
        public string Nome { get; private set; }

        public Bairro(long id, long cidadeId, string nome)
        {
            Id = id;
            CidadeId = cidadeId;
            Nome = nome;
        }

    }
}
