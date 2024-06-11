using MediatR;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Application.Buscador.Localizacao.ConsultarRegioes
{
    public class ConsultarRegioesInput : IRequest<IEnumerable<Regiao>>
    {
        public int? Id { get; private set; }
        public string? Nome { get; private set; }

        public ConsultarRegioesInput(int? id, string? nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
