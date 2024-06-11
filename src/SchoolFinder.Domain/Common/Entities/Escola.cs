using SchoolFinder.Domain.Common.ValueObjects;

namespace SchoolFinder.Domain.Common.Entities
{
    public class Escola
    {
        public long? Id { get; private set; }
        public long? IdExterno { get; private set; }
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

        public Escola()
        {            
        }

        public Escola(long? id, long? externalId, string? name, string? cnpj, int? schoolTypeId, string? schoolType, int? localizationTypeId, string? localizationType, int? statusId, 
            string? status, EnderecoEscola? endereco, ContatoEscola? contatos, CensoEscola? dadosCenso)
        {
            Id = id;
            IdExterno = externalId;
            Nome = name;
            Cnpj = cnpj;
            TipoEscolaId = schoolTypeId;
            TipoEscola = schoolType;
            TipoLocalizacaoId = localizationTypeId;
            TipoLocalizacao = localizationType;
            StatusId = statusId;
            Status = status;
            Endereco = endereco;
            Contatos = contatos;
            DadosCenso = dadosCenso;

            Validate();
        }

        public void SetEndereco(EnderecoEscola endereco)
        {
            Endereco = endereco;
            Validate();
        }

        public void SetContato(ContatoEscola contatos)
        {
            Contatos = contatos;
            Validate();
        }

        public void SetDadosCenso(CensoEscola censo)
        {
            DadosCenso = censo;
            Validate();
        }

        // TODO: Implementar...
        private void Validate()
        {

        }
    }
}
