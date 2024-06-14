using backend_pokemon_challenge.api.Middlewares;
using Microsoft.OpenApi.Models;
using Serilog;

namespace backend_pokemon_challenge.api.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static void AddPresentation(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc(
                    "v1",
                    new OpenApiInfo { Title = "Pokemon Challenge", Version = "v1" }
                );
            });

            builder.Services.AddScoped<ErrorHandlingMiddleware>();

            builder.Host.UseSerilog(
                (context, configuration) =>
                    configuration.ReadFrom.Configuration(context.Configuration)
            );
        }
    }
}
