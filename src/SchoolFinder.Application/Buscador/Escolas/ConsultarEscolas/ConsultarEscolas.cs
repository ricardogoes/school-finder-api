using MediatR;
using SchoolFinder.Domain.Buscador.Interfaces;
using SchoolFinder.Domain.Common.Models;

namespace SchoolFinder.Application.Buscador.Escolas.ConsultarEscolas
{
    public class ConsultarEscolas : IRequestHandler<ConsultarEscolasInput, ListaPaginadaOutput<EscolaOutput>>
    {
        private readonly IBuscadorRepository _repository;

        public ConsultarEscolas(IBuscadorRepository repository)
        {
            _repository = repository;
        }

        public async Task<ListaPaginadaOutput<EscolaOutput>> Handle(ConsultarEscolasInput input, CancellationToken cancellationToken)
        {
            var filtros = new Dictionary<string, object?>
            {
                { "Nome", input.Nome },
                { "Cnpj", input.Cnpj },
                { "Endereco", input.Endereco },
                { "Cep", input.Cep },
                { "BairroId", input.BairroId },
                { "CidadeId", input.CidadeId }
            };

            var escolas = await _repository.ConsultarEscolasPaginadoAsync(
                filtros, input.NumeroPagina, input.QuantidadeRegistros, input.Ordenacao!,
                cancellationToken: cancellationToken);

            return new ListaPaginadaOutput<EscolaOutput>
            (
                numeroPagina: input.NumeroPagina,
                quantidadeRegistros: input.QuantidadeRegistros,
                totalPaginas: ListaPaginadaOutput<EscolaOutput>.ConsultarTotalPaginas(escolas.TotalRegistros, input.QuantidadeRegistros),
                totalRegistros: escolas.TotalRegistros,
                items: EscolaOutput.APartirDaEscola(escolas.Items)
            );
        }
    }
}
