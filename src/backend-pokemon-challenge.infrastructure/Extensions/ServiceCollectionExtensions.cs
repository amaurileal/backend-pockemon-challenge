using backend_pokemon_challenge.domain.Repositories;
using backend_pokemon_challenge.infrastructure.Persistence;
using backend_pokemon_challenge.infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace backend_pokemon_challenge.infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Database");
            services.AddDbContext<PokemonChallengeDdContext>(options => {
                options.UseSqlite(connectionString);
            });

            services.AddScoped<IPokemonMasterRepository, PokemonMasterRepository>();
            services.AddScoped<ICapturedPokemonRepository, CapturedPokemonRepository>();
        }
    }
}
