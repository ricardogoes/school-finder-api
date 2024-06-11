using FluentValidation;

namespace SchoolFinder.Application.Buscador.Escolas.ConsultarEscolaPeloId
{
    public class ConsultarEscolaPeloIdInputValidator
        : AbstractValidator<ConsultarEscolaPeloIdInput>
    {
        public ConsultarEscolaPeloIdInputValidator()
            => RuleFor(x => x.Id).NotEmpty();
    }
}
