using MediatR;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Application.Buscador.Localizacao.ConsultarEstados
{
    public class ConsultarEstadosInput : IRequest<IEnumerable<Estado>>
    {
        public int? Id { get; private set; }
        public int? RegiaoId { get; private set; }
        public string? Nome { get; private set; }

        public ConsultarEstadosInput(int? id, int? regiaoId, string? nome)
        {
            Id = id;
            RegiaoId = regiaoId;
            Nome = nome;
        }
    }
}
