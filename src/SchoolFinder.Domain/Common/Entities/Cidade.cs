namespace SchoolFinder.Domain.Common.Entities
{
    public class Cidade
    {        
        public long Id { get; private set; }
        public int EstadoId { get; private set; }
        public string UF { get; private set; }
        public string Nome { get; private set; }

        public Cidade(long id, int estadoId, string uF, string nome)
        {
            Id = id;
            EstadoId = estadoId;
            UF = uF;
            Nome = nome;
        }
    }
}
