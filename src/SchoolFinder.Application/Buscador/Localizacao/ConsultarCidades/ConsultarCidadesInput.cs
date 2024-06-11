using MediatR;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Application.Buscador.Localizacao.ConsultarCidades
{
    public class ConsultarCidadesInput : IRequest<IEnumerable<Cidade>>
    {
        public long? Id { get; private set; }
        public int? EstadoId { get; private set; }
        public string? Nome { get; private set; }

        public ConsultarCidadesInput(long? id, int? estadoId, string? nome)
        {
            Id = id;
            EstadoId = estadoId;
            Nome = nome;
        }
    }
}
