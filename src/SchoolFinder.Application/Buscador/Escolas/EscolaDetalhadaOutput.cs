using SchoolFinder.Domain.Common.Entities;
using SchoolFinder.Domain.Common.ValueObjects;

namespace SchoolFinder.Application.Buscador.Escolas
{
    public class EscolaDetalhadaOutput
    {

        public long? Id { get; private set; }
        public string? Nome { get; private set; }
        public string? Cnpj { get; private set; }
        public int? TipoEscolaId { get; set; }
        public string? TipoEscola { get; private set; }
        public int? TipoLocalizacaoId { get; private set; }
        public string? TipoLocalizacao { get; private set; }
        public int? StatusId { get; private set; }
        public string? Status { get; private set; }
        public EnderecoEscola? Endereco { get; private set; }
        public ContatoEscola? Contatos { get; private set; }
        public CensoEscola? DadosCenso { get; private set; }

        public EscolaDetalhadaOutput(long? id, string? nome, string? cnpj, int? tipoEscolaId, string? tipoEscola, int? tipoLocalizacaoId, string? tipoLocalizacao,
            int? statusId, string? status, EnderecoEscola? endereco, ContatoEscola? contatos, CensoEscola? dadosCenso)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            TipoEscolaId = tipoEscolaId;
            TipoEscola = tipoEscola;
            TipoLocalizacaoId = tipoLocalizacaoId;
            TipoLocalizacao = tipoLocalizacao;
            StatusId = statusId;
            Status = status;
            Endereco = endereco;
            Contatos = contatos;
            DadosCenso = dadosCenso;
        }

        public static EscolaDetalhadaOutput APartirDaEscola(Escola escola)
        {
            return new EscolaDetalhadaOutput
            (
                escola.Id,
                escola.Nome,
                escola.Cnpj,
                escola.TipoEscolaId,
                escola.TipoEscola,
                escola.TipoLocalizacaoId,
                escola.TipoLocalizacao,
                escola.StatusId,
                escola.Status,
                escola.Endereco,
                escola.Contatos,
                escola.DadosCenso
            );
        }

        public static IEnumerable<EscolaDetalhadaOutput> APartirDaEscola(IEnumerable<Escola> escolas)
            => escolas.Select(escola => APartirDaEscola(escola));
    }
}
