using backend_pokemon_challenge.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace backend_pokemon_challenge.infrastructure.Persistence
{
    public class PokemonChallengeDdContext(DbContextOptions<PokemonChallengeDdContext> options) : DbContext(options)
    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=pokemon.db");
        //}

        public DbSet<PokemonMaster> PokemonMasters { get; set; }

        public DbSet<CapturedPokemon> CapturedPokemons { get; set; }      
        
        


    }
}
