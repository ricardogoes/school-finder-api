using FluentValidation;
using MediatR;
using SchoolFinder.Domain.Buscador.Interfaces;
using SchoolFinder.Domain.Common.CustomExceptions;

namespace SchoolFinder.Application.Buscador.Escolas.ConsultarEscolaPeloId
{
    public class ConsultarEscolaPeloId : IRequestHandler<ConsultarEscolaPeloIdInput, EscolaDetalhadaOutput>
    {
        private readonly IBuscadorRepository _repository;
        private readonly IValidator<ConsultarEscolaPeloIdInput> _validator;

        public ConsultarEscolaPeloId(IBuscadorRepository repository, IValidator<ConsultarEscolaPeloIdInput> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public async Task<EscolaDetalhadaOutput> Handle(ConsultarEscolaPeloIdInput input, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(input, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new EntityValidationException($"Ocorreu um ou mais erros de validação. {nameof(input)}.", validationResult.ToDictionary());
            }

            var escola = await _repository.ConsultarEscolasPeloIdAsync(input.Id, cancellationToken);
            return EscolaDetalhadaOutput.APartirDaEscola(escola);
        }
    }
}
