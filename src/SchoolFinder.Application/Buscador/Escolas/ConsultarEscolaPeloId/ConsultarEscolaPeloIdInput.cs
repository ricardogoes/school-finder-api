using MediatR;

namespace SchoolFinder.Application.Buscador.Escolas.ConsultarEscolaPeloId
{
    public class ConsultarEscolaPeloIdInput : IRequest<EscolaDetalhadaOutput>
    {
        public long Id { get; set; }
    }
}
