using backend_pokemon_challenge.application.Services.Dtos;
using MediatR;

namespace backend_pokemon_challenge.application.Pokemons.Queries.GetAllCapturedPokemons
{
    public class GetAllCapturedPokemonsQuery : IRequest<IEnumerable<PokemonDto>>
    {
    }
}
