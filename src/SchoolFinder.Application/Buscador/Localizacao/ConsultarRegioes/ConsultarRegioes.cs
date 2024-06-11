using MediatR;
using SchoolFinder.Domain.Buscador.Interfaces;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Application.Buscador.Localizacao.ConsultarRegioes
{
    public class ConsultarRegioes : IRequestHandler<ConsultarRegioesInput, IEnumerable<Regiao>>
    {
        private readonly IBuscadorRepository _repository;

        public ConsultarRegioes(IBuscadorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Regiao>> Handle(ConsultarRegioesInput input, CancellationToken cancellationToken)
        {
            var filtros = new Dictionary<string, object?>
            {
                { "Id", input.Id },
                { "Nome", input.Nome },

            };

            var estados = await _repository.ConsultarRegioesAsync(filtros, cancellationToken);

            return estados;
        }
    }
}
