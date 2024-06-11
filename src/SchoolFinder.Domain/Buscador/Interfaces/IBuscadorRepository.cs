using SchoolFinder.Domain.Common.Entities;
using SchoolFinder.Domain.Common.Models;

namespace SchoolFinder.Domain.Buscador.Interfaces
{
    public interface IBuscadorRepository
    {
        Task<Escola> ConsultarEscolasPeloIdAsync(long id, CancellationToken cancellationToken);

        Task<ListaPaginadaOutput<Escola>> ConsultarEscolasPaginadoAsync(Dictionary<string, object?> filtros, int numeroPagina, int quantidadeRegistros, string ordenacao, CancellationToken cancellationToken);

        Task<IEnumerable<Regiao>> ConsultarRegioesAsync(Dictionary<string, object?> filtros, CancellationToken cancellationToken);
        Task<IEnumerable<Estado>> ConsultarEstadosAsync(Dictionary<string, object?> filtros, CancellationToken cancellationToken);
        Task<IEnumerable<Cidade>> ConsultarCidadesAsync(Dictionary<string, object?> filtros, CancellationToken cancellationToken);
        Task<IEnumerable<Bairro>> ConsultarBairrosAsync(Dictionary<string, object?> filtros, CancellationToken cancellationToken);
    }
}
