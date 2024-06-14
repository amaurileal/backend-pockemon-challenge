using backend_pokemon_challenge.application.Services.Dtos;

namespace backend_pokemon_challenge.application.Services
{
    public interface IPokemonApiService
    {
        Task<List<PokemonDto>> GetPokemonsAsync();

        Task<PokemonDto> GetPokemonAsync(int id);
    }
}
