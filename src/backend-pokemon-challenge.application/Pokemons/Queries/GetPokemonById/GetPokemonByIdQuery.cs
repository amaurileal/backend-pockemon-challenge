using backend_pokemon_challenge.application.Services.Dtos;
using MediatR;

namespace backend_pokemon_challenge.application.Pokemons.Queries.GetPokemonById
{
    public class GetPokemonByIdQuery : IRequest<PokemonDto>
    {
        public int Id { get; set; }
    }
}
