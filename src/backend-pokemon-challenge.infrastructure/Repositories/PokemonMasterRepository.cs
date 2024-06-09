using backend_pokemon_challenge.domain.Entities;
using backend_pokemon_challenge.domain.Repositories;
using backend_pokemon_challenge.infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace backend_pokemon_challenge.infrastructure.Repositories
{
    internal class PokemonMasterRepository(PokemonChallengeDdContext dbContext) : IPokemonMasterRepository
    {
        public async Task<int> Create(PokemonMaster entity)
        {
            dbContext.PokemonMasters.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(PokemonMaster entity)
        {
            dbContext.PokemonMasters.Remove(entity);
            await dbContext.SaveChangesAsync();
           
        }

        public async Task<PokemonMaster?> FindByIdAsync(int id)
        {
            var pokemonMaster = await dbContext.PokemonMasters.FirstOrDefaultAsync(x => x.Id == id);
            return pokemonMaster;
        }

        public async Task<IEnumerable<PokemonMaster>> GetAllByAsync()
        {
            var pokemonMasters = await dbContext.PokemonMasters.ToListAsync();
            return pokemonMasters;
        }

        public Task SaveChanges() => dbContext.SaveChangesAsync();
    }
}
