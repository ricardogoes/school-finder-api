namespace SchoolFinder.Domain.Common.Models
{
    public class ListaPaginadaOutput<T> where T : class
    {
        public int NumeroPagina { get; private set; }
        public int QuantidadeRegistros { get; private set; }
        public int TotalPaginas { get; private set; }
        public int TotalRegistros { get; private set; }
        public IEnumerable<T> Items { get; private set; }

        public ListaPaginadaOutput(int numeroPagina, int quantidadeRegistros, int totalPaginas, int totalRegistros, IEnumerable<T> items)
        {
            NumeroPagina = numeroPagina;
            QuantidadeRegistros = quantidadeRegistros;
            TotalPaginas = totalPaginas;
            TotalRegistros = totalRegistros;
            Items = items;
        }

        public ListaPaginadaOutput(int totalRegistros, IEnumerable<T> items)
        {
            TotalRegistros = totalRegistros;
            Items = items;
        }

        public static int ConsultarTotalPaginas(int totalRegistros, int quantidadeRegistros)
            => totalRegistros < quantidadeRegistros
            ? 1
            : Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(totalRegistros) / Convert.ToDecimal(quantidadeRegistros)));
    }
}
