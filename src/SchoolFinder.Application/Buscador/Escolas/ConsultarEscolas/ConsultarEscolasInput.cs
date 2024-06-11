using MediatR;
using SchoolFinder.Application.Buscador.Escolas;
using SchoolFinder.Domain.Common.Models;

namespace SchoolFinder.Application.Buscador.Escolas.ConsultarEscolas
{
    public class ConsultarEscolasInput : ListaPaginadaInput, IRequest<ListaPaginadaOutput<EscolaOutput>>
    {
        public string? Nome { get; private set; }
        public string? Cnpj { get; private set; }
        public string? Endereco { get; private set; }
        public string? Cep { get; private set; }
        public long? BairroId { get; private set; }
        public long? CidadeId { get; private set; }

        public ConsultarEscolasInput(int numeroPagina, int quantidadeRegistros, string? ordenacao = null,
            string? nome = null, string? cnpj = null, string? endereco = null, long? bairro_id = null, string? cep = null,
            long? cidadeId = null)
            : base(numeroPagina, quantidadeRegistros, ordenacao)
        {
            Nome = nome;
            Cnpj = cnpj;
            Endereco = endereco;
            BairroId = bairro_id;
            Cep = cep;
            CidadeId = cidadeId;
        }
    }
}
