using Bogus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolFinder.Domain.Common.Models.AppSettings;
using SchoolFinder.EndToEndTests.Configurations;

namespace SchoolFinder.EndToEndTests
{
    public abstract class BaseFixture
    {
        protected Faker Faker { get; set; }
        public CustomWebApplicationFactory<Program> WebAppFactory { get; set; }
        public HttpClient HttpClient { get; set; }
        public ApiClient ApiClient { get; set; }
                
        protected BaseFixture()
        {
            Faker = new Faker("pt_BR");

            WebAppFactory = new CustomWebApplicationFactory<Program>();
            HttpClient = WebAppFactory.CreateClient();

            var configuration = WebAppFactory.Services.GetRequiredService<IConfiguration>();
            ArgumentNullException.ThrowIfNull(configuration);

            var connectionStrings = new ConnectionStringsSettings(Environment.GetEnvironmentVariable("SchoolFinderSettings:ConnectionStrings:SchoolFinderDB")!);

            var appSettings = new AppSettings(connectionStrings);
            ApiClient = new ApiClient(HttpClient);            
        }

        //public OdinBaselineDbContext CreateDbContext(bool preserveData = false)
        //{
        //    var tenantService = WebAppFactory.Services.GetRequiredService<ITenantService>();

        //    var context = new OdinBaselineDbContext(
        //        new DbContextOptionsBuilder<OdinBaselineDbContext>()
        //        .UseInMemoryDatabase("e2e-tests-db")
        //        .Options,
        //        tenantService
        //    );

        //    if (preserveData == false)
        //        context.Database.EnsureDeleted();

        //    return context;
        //}

        public bool GetRandomBoolean()
            => new Random().NextDouble() < 0.5;

    }
}
