using Asp.Versioning;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.OpenApi.Models;
using SchoolFinder.Api.Configurations;
using SchoolFinder.Api.Filters;
using SchoolFinder.Domain.Common.Models.AppSettings;
using SchoolFinder.Infra.Messaging.JsonPolicies;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    {
        policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var connectionStrings = new ConnectionStringsSettings(Environment.GetEnvironmentVariable("SchoolFinderSettings:ConnectionStrings:SchoolFinderDB")!);

var appSettings = new AppSettings(connectionStrings);

// Add services to the container.
builder.Services
    .AddSingleton(appSettings)
    .AddHttpContextAccessor()    
    .AddApplications()
    .AddRepositories()
    .AddEndpointsApiExplorer()
    .AddSwaggerGen(option =>
    {
        option.SwaggerDoc("v1", new OpenApiInfo { Title = "School Finder", Version = "v1" });        
    })        
    .AddResponseCompression(options =>
    {
        options.EnableForHttps = true;
        options.Providers.Add<BrotliCompressionProvider>();
        options.Providers.Add<GzipCompressionProvider>();
    })
    .AddControllers(options =>
    {
        options.Filters.Add(typeof(ApiExceptionFilter));
    })
    .AddJsonOptions(jsonOptions =>
    {
        jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = new JsonSnakeCasePolicy();
        jsonOptions.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
        jsonOptions.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddApiVersioning(options =>
    {
        // Retorna os headers "api-supported-versions" e "api-deprecated-versions"
        // indicando versoes suportadas pela API e o que esta como deprecated
        options.ReportApiVersions = true;

        options.AssumeDefaultVersionWhenUnspecified = true;
        options.DefaultApiVersion = new ApiVersion(1, 0);
    })
   .AddApiExplorer(options =>
   {
       // Agrupar por numero de versao
       // add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
       // note: the specified format code will format the version as "'v'major[.minor][-status]"
       options.GroupNameFormat = "'v'VVV";

       // Necessario para o correto funcionamento das rotas
       // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
       // can also be used to control the format of the API version in route templates
       options.SubstituteApiVersionInUrl = true;
   });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseResponseCompression();
app.MapControllers();

app.Run();

public partial class Program { }