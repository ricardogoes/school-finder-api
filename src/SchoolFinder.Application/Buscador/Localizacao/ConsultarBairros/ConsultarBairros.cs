using MediatR;
using SchoolFinder.Domain.Buscador.Interfaces;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Application.Buscador.Localizacao.ConsultarBairros
{
    public class ConsultarBairros : IRequestHandler<ConsultarBairrosInput, IEnumerable<Bairro>>
    {
        private readonly IBuscadorRepository _repository;

        public ConsultarBairros(IBuscadorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Bairro>> Handle(ConsultarBairrosInput input, CancellationToken cancellationToken)
        {
            var filtros = new Dictionary<string, object?>
            {
                { "Id", input.Id },
                { "CidadeId", input.CidadeId },
                { "Nome", input.Nome },

            };

            var bairros = await _repository.ConsultarBairrosAsync(filtros, cancellationToken);

            return bairros;
        }
    }
}
