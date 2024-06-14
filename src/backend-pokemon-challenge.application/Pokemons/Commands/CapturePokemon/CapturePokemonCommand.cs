using MediatR;

namespace backend_pokemon_challenge.application.Pokemons.Commands.CapturePokemon
{
    public class CapturePokemonCommand:IRequest<int>
    {
        public int PokemonMasterId { get; set; }

       
        public int PokemonId { get; set; }

        
        public string Name { get; set; } = default!;

        public string Url { get; set; } = default!;
    }
}
