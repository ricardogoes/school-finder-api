namespace SchoolFinder.Domain.Common.Models
{
    public abstract class ListaPaginadaInput
    {

        public int NumeroPagina { get; private set; }
        public int QuantidadeRegistros { get; private set; }
        public string? Ordenacao { get; private set; }

        protected ListaPaginadaInput()
        {
            NumeroPagina = 1;
            QuantidadeRegistros = 10;
            Ordenacao = "nome";
        }

        protected ListaPaginadaInput(int numeroPagina, int quantidadeRegistros, string? ordenacao)
        {
            NumeroPagina = numeroPagina < 1 ? 1 : numeroPagina;
            QuantidadeRegistros = quantidadeRegistros;
            Ordenacao = ordenacao ?? "nome";
        }
    }
}
