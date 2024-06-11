using MediatR;
using SchoolFinder.Domain.Buscador.Interfaces;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Application.Buscador.Localizacao.ConsultarCidades
{
    public class ConsultarCidades : IRequestHandler<ConsultarCidadesInput, IEnumerable<Cidade>>
    {
        private readonly IBuscadorRepository _repository;

        public ConsultarCidades(IBuscadorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Cidade>> Handle(ConsultarCidadesInput input, CancellationToken cancellationToken)
        {
            var filtros = new Dictionary<string, object?>
            {
                { "Id", input.Id },
                { "EstadoId", input.EstadoId },
                { "Nome", input.Nome },

            };

            var cidades = await _repository.ConsultarCidadesAsync(filtros, cancellationToken);

            return cidades;
        }
    }
}
