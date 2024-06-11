using FluentValidation;
using SchoolFinder.Application.Buscador.Escolas.ConsultarEscolaPeloId;

namespace SchoolFinder.Api.Configurations
{
    public static class ApplicationConfiguration
    {

        public static IServiceCollection AddApplications(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(ConsultarEscolaPeloId).Assembly);
            });


            ValidatorOptions.Global.LanguageManager.Enabled = false;

            services.AddValidatorsFromAssemblyContaining<ConsultarEscolaPeloIdInputValidator>();

            return services;
        }
    }
}
