using MediatR;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Application.Buscador.Localizacao.ConsultarBairros
{
    public class ConsultarBairrosInput : IRequest<IEnumerable<Bairro>>
    {
        public long? Id { get; private set; }
        public long? CidadeId { get; private set; }
        public string? Nome { get; private set; }

        public ConsultarBairrosInput(long? id, long? cidadeId, string? nome)
        {
            Id = id;
            CidadeId = cidadeId;
            Nome = nome;
        }
    }
}
