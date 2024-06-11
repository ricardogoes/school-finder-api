using SchoolFinder.Domain.Buscador.Interfaces;
using SchoolFinder.Infra.Data.Dapper.Buscador.Repositories;

namespace SchoolFinder.Api.Configurations
{
    public static class RepositoriesConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBuscadorRepository, BuscadorRepository>();
            return services;
        }
    }
}
