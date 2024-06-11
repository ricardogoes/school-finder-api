using MediatR;
using SchoolFinder.Domain.Buscador.Interfaces;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Application.Buscador.Localizacao.ConsultarEstados
{
    public class ConsultarEstados : IRequestHandler<ConsultarEstadosInput, IEnumerable<Estado>>
    {
        private readonly IBuscadorRepository _repository;

        public ConsultarEstados(IBuscadorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Estado>> Handle(ConsultarEstadosInput input, CancellationToken cancellationToken)
        {
            var filtros = new Dictionary<string, object?>
            {
                { "Id", input.Id },
                { "RegiaoId", input.RegiaoId },
                { "Nome", input.Nome },

            };

            var estados = await _repository.ConsultarEstadosAsync(filtros, cancellationToken);

            return estados;
        }
    }
}
