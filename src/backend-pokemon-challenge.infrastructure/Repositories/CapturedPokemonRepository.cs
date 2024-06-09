using backend_pokemon_challenge.domain.Entities;
using backend_pokemon_challenge.domain.Repositories;
using backend_pokemon_challenge.infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace backend_pokemon_challenge.infrastructure.Repositories
{
    internal class CapturedPokemonRepository(PokemonChallengeDdContext dbContext) : ICapturedPokemonRepository
    {
        public async Task<int> Capture(CapturedPokemon entity)
        {
            dbContext.CapturedPokemons.Add(entity);
            await dbContext.SaveChangesAsync();

            return entity.Id;

        }

        public async Task<IEnumerable<CapturedPokemon>> GetAll()
        {
            var capturedPokemons = await dbContext.CapturedPokemons.ToListAsync();
            return capturedPokemons;    
        }

        public async Task<IEnumerable<CapturedPokemon>> GetAllByPokemonMaster(int pokemonMasterId)
        {
            var caturedPokemons = await dbContext.CapturedPokemons.Where(x => x.PokemonMasterId == pokemonMasterId).ToListAsync();
            return caturedPokemons;
        }
    }
}
