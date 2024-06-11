using SchoolFinder.Domain.Common.Models;

namespace SchoolFinder.Api.Models
{
    public class PaginatedApiResponse<TItemData> where TItemData : class
    {
        public int NumeroPagina { get; set; }

        public int QuantidadeRegistros { get; set; }

        public int TotalPaginas { get; set; }

        public int TotalRegistros { get; set; }

        public IEnumerable<TItemData> Items { get; set; } = Enumerable.Empty<TItemData>();

        public PaginatedApiResponse()
        { }

        public PaginatedApiResponse(ListaPaginadaOutput<TItemData> data)
        {
            NumeroPagina = data.NumeroPagina;
            QuantidadeRegistros = data.QuantidadeRegistros;
            TotalPaginas = data.TotalPaginas;
            TotalRegistros = data.TotalRegistros;
            Items = data.Items;
        }
    }
}
