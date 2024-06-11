namespace SchoolFinder.Domain.Common.ValueObjects
{
    public class EnderecoEscola
    {
        public string? Endereco { get; private set; }
        public string? EnderecoNumero { get; private set; }
        public string? Complemento { get; private set; }
        public string? Bairro { get; private set; }
        public string? Cep { get; private set; }
        public long? CidadeId { get; private set; }
        public string? Cidade { get; private set; }
        public int? EstadoId { get; private set; }
        public string? Estado { get; private set; }
        public int? RegiaoId { get; private set; }
        public string? Regiao { get; private set; }

        public EnderecoEscola()
        {            
        }

        public EnderecoEscola(string? endereco, string? enderecoNumero, string? complemento, string? bairro, string? cep, long? cidadeId, string? cidade, int? estadoId, string? estado, int? regiaoId, string? regiao)
        {
            Endereco = endereco;
            EnderecoNumero = enderecoNumero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            CidadeId = cidadeId;
            Cidade = cidade;
            EstadoId = estadoId;
            Estado = estado;
            RegiaoId = regiaoId;
            Regiao = regiao;

            Validate();
        }

        // TODO: Implementar...
        private void Validate()
        {

        }
    }
}
