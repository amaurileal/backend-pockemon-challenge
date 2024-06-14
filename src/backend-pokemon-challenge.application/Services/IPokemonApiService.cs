using backend_pokemon_challenge.application.Services.Dtos;

namespace backend_pokemon_challenge.application.Services
{
    public interface IPokemonApiService
    {
        Task<List<PokemonDto>> GetPokemonsAsync(int limit, int offset);

        Task<PokemonDto> GetPokemonAsync(int id);
    }
}
